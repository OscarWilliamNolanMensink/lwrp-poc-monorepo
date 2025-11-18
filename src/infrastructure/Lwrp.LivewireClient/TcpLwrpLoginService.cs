using System.Net.Sockets;
using System.Text;
using Lwrp.Application.Auth;
using Microsoft.Extensions.Options;
using Lwrp.Contracts;


namespace Lwrp.LivewireClient;

public sealed class TcpLwrpLoginService : ILwrpLoginService, IAsyncDisposable
{
    private readonly LwrpConnectionOptions _options;
    private TcpClient? _client;
    private NetworkStream? _stream;

    public TcpLwrpLoginService(IOptions<LwrpConnectionOptions> options)
    {
        _options = options.Value;
    }

    public async Task<Result> LoginAsync(string password, CancellationToken cancellationToken = default)
    {
        try
        {
            // 1. Ensure TCP connection
            if (_client is null || !_client.Connected)
            {
                _client = new TcpClient();
                await _client.ConnectAsync(_options.Host, _options.Port, cancellationToken);
                _stream = _client.GetStream();
            }

            if (_stream is null)
            {
                return Result.Failure("Network stream is not available.");
            }

            // 2. Build LWRP LOGIN command
            // spec: 'LOGIN <password>' or 'LOGIN' for read-only
            var command = string.IsNullOrWhiteSpace(password)
                ? "LOGIN"
                : $"LOGIN {password}";

            var line = command + "\n"; // LWRP is line-based ASCII with LF/CRLF
            var bytes = Encoding.ASCII.GetBytes(line);

            // 3. Send
            await _stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken);
            await _stream.FlushAsync(cancellationToken);

            // 4. (Optional) read one line as response from mock server
            //    If your mock echoes something back, you can read it here.
            // using var reader = new StreamReader(_stream, Encoding.ASCII, leaveOpen: true);
            // var response = await reader.ReadLineAsync();

            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"Login failed: {ex.Message}");
        }
    }

    public async ValueTask DisposeAsync()
    {
        _stream?.Dispose();
        _client?.Close();
        await Task.CompletedTask;
    }
}
