using System.Net.Sockets;
using System.Text;
using Lwrp.Contracts;
using Microsoft.Extensions.Options;

namespace Lwrp.LivewireClient;

public sealed class ResilientLwrpConnection : ILwrpConnection, IAsyncDisposable
{
    private readonly LwrpConnectionOptions _options;
    private readonly SemaphoreSlim _lock = new(1, 1);

    private TcpClient? _client;
    private NetworkStream? _stream;
    private StreamReader? _reader;
    private StreamWriter? _writer;

    public ResilientLwrpConnection(IOptions<LwrpConnectionOptions> options)
    {
        _options = options.Value;
    }

    private async Task EnsureConnectedAsync(CancellationToken ct)
    {
        if (_client is { Connected: true } && _stream is not null && _reader is not null && _writer is not null)
            return;

        await _lock.WaitAsync(ct);
        try
        {
            if (_client is { Connected: true } && _stream is not null && _reader is not null && _writer is not null)
                return;

            _reader?.Dispose();
            _writer?.Dispose();
            _stream?.Dispose();
            _client?.Close();

            _client = new TcpClient();
            await _client.ConnectAsync(_options.Host, _options.Port, ct);

            _stream = _client.GetStream();
            _reader = new StreamReader(_stream, Encoding.ASCII, leaveOpen: true);
            _writer = new StreamWriter(_stream, Encoding.ASCII) { AutoFlush = true };
            
        }
        finally
        {
            _lock.Release();
        }
    }

    public async Task<string?> SendCommandAsync(string command, CancellationToken ct = default)
    {
        await EnsureConnectedAsync(ct);

        try
        {
            await _writer!.WriteLineAsync(command);
            return await _reader!.ReadLineAsync();
        }
        catch (IOException)
        {
            await ReconnectAsync(ct);
            await _writer!.WriteLineAsync(command);
            return await _reader!.ReadLineAsync();
        }
        catch (SocketException)
        {
            await ReconnectAsync(ct);
            await _writer!.WriteLineAsync(command);
            return await _reader!.ReadLineAsync();
        }
    }

    private async Task ReconnectAsync(CancellationToken ct)
    {
        await _lock.WaitAsync(ct);
        try
        {
            _reader?.Dispose();
            _writer?.Dispose();
            _stream?.Dispose();
            _client?.Close();

            _client = new TcpClient();

            // Simple backoff; you can later swap in Polly if you like
            var delays = new[] { 0, 500, 1000, 2000, 5000 };
            Exception? last = null;

            foreach (var delay in delays)
            {
                if (delay > 0)
                    await Task.Delay(delay, ct);

                try
                {
                    await _client.ConnectAsync(_options.Host, _options.Port, ct);

                    _stream = _client.GetStream();
                    _reader = new StreamReader(_stream, Encoding.ASCII, leaveOpen: true);
                    _writer = new StreamWriter(_stream, Encoding.ASCII) { AutoFlush = true };

                    return; // success
                }
                catch (Exception ex)
                {
                    last = ex;
                }
            }

            throw new InvalidOperationException("Could not reconnect to LWRP device.", last);
        }
        finally
        {
            _lock.Release();
        }
    }

    public async ValueTask DisposeAsync()
    {
        _reader?.Dispose();
        _writer?.Dispose();
        _stream?.Dispose();
        _client?.Close();
        _lock.Dispose();
        await Task.CompletedTask;
    }
}
