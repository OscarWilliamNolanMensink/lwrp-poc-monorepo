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

    // Last successfully used password for this connection (if any)
    private string? _lastPassword;

    public ResilientLwrpConnection(IOptions<LwrpConnectionOptions> options)
    {
        _options = options.Value;
    }

    private async Task EnsureConnectedAsync(CancellationToken ct)
    {
        // Fast path: connection already up & usable
        if (_client is { Connected: true } && _stream is not null && _reader is not null && _writer is not null)
            return;

        await _lock.WaitAsync(ct);
        try
        {
            // Check again inside the lock in case another thread fixed it
            if (_client is { Connected: true } && _stream is not null && _reader is not null && _writer is not null)
                return;

            // Clean up any previous state
            _reader?.Dispose();
            _writer?.Dispose();
            _stream?.Dispose();
            _client?.Close();

            _client = new TcpClient();
            await _client.ConnectAsync(_options.Host, _options.Port, ct);

            _stream = _client.GetStream();
            _reader = new StreamReader(_stream, Encoding.ASCII, leaveOpen: true);
            _writer = new StreamWriter(_stream, Encoding.ASCII) { AutoFlush = true };

            // NOTE: No auto-login here. Re-login is handled in ReconnectAsync
            // using the last remembered password, if any.
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
            // Connection broken: reconnect and retry once
            await ReconnectAsync(ct);
            await _writer!.WriteLineAsync(command);
            return await _reader!.ReadLineAsync();
        }
        catch (SocketException)
        {
            // Connection broken: reconnect and retry once
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

            // Simple backoff strategy; adjust as needed
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

                    // If we previously logged in with a password, re-login now
                    if (!string.IsNullOrWhiteSpace(_lastPassword))
                    {
                        var loginCommand = $"LOGIN {_lastPassword}";
                        await _writer.WriteLineAsync(loginCommand);

                        // Optionally read and ignore the response (depends on your mock/device)
                        // _ = await _reader.ReadLineAsync();
                    }

                    return; // Reconnect (and re-login, if needed) succeeded
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

    public void RememberPassword(string password)
    {
        // No heavy synchronization needed; string assignment is atomic.
        // ReconnectAsync reads it inside the lock.
        _lastPassword = password;
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
