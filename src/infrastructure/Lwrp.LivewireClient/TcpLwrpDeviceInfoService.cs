using System.Net.Sockets;
using System.Text;
using Lwrp.Application.Device;
using Lwrp.Contracts;
using Microsoft.Extensions.Options;

namespace Lwrp.LivewireClient;

// TODO use existing TCP connection do not create a new one. Lame that it suggests thsi frst.

public sealed class TcpLwrpDeviceInfoService : ILwrpDeviceInfoService, IAsyncDisposable
{
    private readonly LwrpConnectionOptions _options;

    private TcpClient? _client;
    private NetworkStream? _stream;
    private StreamReader? _reader;
    private StreamWriter? _writer;

    public TcpLwrpDeviceInfoService(IOptions<LwrpConnectionOptions> options)
    {
        _options = options.Value;
    }

    private async Task EnsureConnectedAsync(CancellationToken cancellationToken)
    {
        if (_client is { Connected: true } && _stream is not null && _reader is not null && _writer is not null)
            return;

        _client?.Dispose();

        _client = new TcpClient();
        await _client.ConnectAsync(_options.Host, _options.Port, cancellationToken);

        _stream = _client.GetStream();
        _reader = new StreamReader(_stream, Encoding.ASCII, leaveOpen: true);
        _writer = new StreamWriter(_stream, Encoding.ASCII) { AutoFlush = true };
    }

    private async Task<string> SendCommandAsync(string command, CancellationToken cancellationToken)
    {
        await EnsureConnectedAsync(cancellationToken);

        // LWRP is line-based ASCII
        await _writer!.WriteLineAsync(command);
        var line = await _reader!.ReadLineAsync();
        return line ?? string.Empty;
    }

    public async Task<Result<VerInfo>> GetVersionAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await SendCommandAsync("VER", cancellationToken);

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<VerInfo>.Failure(response);

            // Expect something like:
            // VER LWRP:1.4.2 DEVN:MockDevice SYSV:1.1.1 NSRC:8 NDST:8 NGPI:4 NGPO:4
            var tokens = response.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0 || !tokens[0].Equals("VER", StringComparison.OrdinalIgnoreCase))
                return Result<VerInfo>.Failure($"Unexpected VER response: '{response}'");

            var dict = tokens
                .Skip(1)
                .Select(t => t.Split(':', 2))
                .Where(x => x.Length == 2)
                .ToDictionary(x => x[0], x => x[1]);

            dict.TryGetValue("LWRP", out var lwrp);
            dict.TryGetValue("DEVN", out var devn);
            dict.TryGetValue("SYSV", out var sysv);

            int.TryParse(dict.GetValueOrDefault("NSRC") ?? "0", out var nsrc);
            int.TryParse(dict.GetValueOrDefault("NDST") ?? "0", out var ndst);
            int.TryParse(dict.GetValueOrDefault("NGPI") ?? "0", out var ngpi);
            int.TryParse(dict.GetValueOrDefault("NGPO") ?? "0", out var ngpo);

            var info = new VerInfo(
                lwrp ?? string.Empty,
                devn ?? string.Empty,
                sysv ?? string.Empty,
                nsrc,
                ndst,
                ngpi,
                ngpo);

            return Result<VerInfo>.Success(info);
        }
        catch (Exception ex)
        {
            return Result<VerInfo>.Failure($"VER failed: {ex.Message}");
        }
    }

    public async Task<Result<IpConfig>> GetIpConfigAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await SendCommandAsync("IP", cancellationToken);

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure(response);

            // Expect: IP address:1.2.3.4 netmask:... gateway:... hostname:...
            var tokens = response.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0 || !tokens[0].Equals("IP", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure($"Unexpected IP response: '{response}'");

            var dict = tokens
                .Skip(1)
                .Select(t => t.Split(':', 2))
                .Where(x => x.Length == 2)
                .ToDictionary(x => x[0], x => x[1]);

            var config = new IpConfig(
                dict.GetValueOrDefault("address") ?? string.Empty,
                dict.GetValueOrDefault("netmask") ?? string.Empty,
                dict.GetValueOrDefault("gateway") ?? string.Empty,
                dict.GetValueOrDefault("hostname") ?? string.Empty);

            return Result<IpConfig>.Success(config);
        }
        catch (Exception ex)
        {
            return Result<IpConfig>.Failure($"IP query failed: {ex.Message}");
        }
    }

    public async Task<Result<IpConfig>> SetIpConfigAsync(IpConfig config, CancellationToken cancellationToken = default)
    {
        try
        {
            // client: IP [address <d.d.d.d>] [netmask <d.d.d.d>] [gateway <d.d.d.d>] [hostname <name>]
            var sb = new StringBuilder("IP");

            if (!string.IsNullOrWhiteSpace(config.Address))
                sb.Append(' ').Append("address ").Append(config.Address);

            if (!string.IsNullOrWhiteSpace(config.Netmask))
                sb.Append(' ').Append("netmask ").Append(config.Netmask);

            if (!string.IsNullOrWhiteSpace(config.Gateway))
                sb.Append(' ').Append("gateway ").Append(config.Gateway);

            if (!string.IsNullOrWhiteSpace(config.Hostname))
                sb.Append(' ').Append("hostname ").Append(config.Hostname);

            var response = await SendCommandAsync(sb.ToString(), cancellationToken);

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure(response);

            // After setting, the mock server echoes the resulting configuration
            // Reuse the parsing from GetIpConfigAsync
            var tokens = response.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0 || !tokens[0].Equals("IP", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure($"Unexpected IP response: '{response}'");

            var dict = tokens
                .Skip(1)
                .Select(t => t.Split(':', 2))
                .Where(x => x.Length == 2)
                .ToDictionary(x => x[0], x => x[1]);

            var resultConfig = new IpConfig(
                dict.GetValueOrDefault("address") ?? string.Empty,
                dict.GetValueOrDefault("netmask") ?? string.Empty,
                dict.GetValueOrDefault("gateway") ?? string.Empty,
                dict.GetValueOrDefault("hostname") ?? string.Empty);

            return Result<IpConfig>.Success(resultConfig);
        }
        catch (Exception ex)
        {
            return Result<IpConfig>.Failure($"IP set failed: {ex.Message}");
        }
    }

    public async Task<Result> SetGlobalParametersAsync(
        IDictionary<string, string> parameters,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (parameters is null || parameters.Count == 0)
                return Result.Failure("No parameters provided.");

            // client: SET name1:value1 [name2:value2 ...]
            var paramTokens = parameters.Select(kvp => $"{kvp.Key}:{kvp.Value}");
            var command = "SET " + string.Join(' ', paramTokens);

            var response = await SendCommandAsync(command, cancellationToken);

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result.Failure(response);

            // Mock just echoes the SET line – if we got here, we consider it success
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"SET failed: {ex.Message}");
        }
    }

    public async ValueTask DisposeAsync()
    {
        _reader?.Dispose();
        _writer?.Dispose();
        _stream?.Dispose();
        _client?.Close();
        await Task.CompletedTask;
    }
}
