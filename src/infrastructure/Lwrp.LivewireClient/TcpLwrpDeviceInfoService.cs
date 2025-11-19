using System.Text;
using Lwrp.Application.Device;
using Lwrp.Contracts;

namespace Lwrp.LivewireClient;

public sealed class TcpLwrpDeviceInfoService : ILwrpDeviceInfoService
{
    private readonly ILwrpConnection _connection;

    public TcpLwrpDeviceInfoService(ILwrpConnection connection)
    {
        _connection = connection;
    }

    public async Task<Result<VerInfo>> GetVersionAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await _connection.SendCommandAsync("VER", cancellationToken)
                           ?? string.Empty;

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<VerInfo>.Failure(response);

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
            var response = await _connection.SendCommandAsync("IP", cancellationToken)
                           ?? string.Empty;

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure(response);

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
            var sb = new StringBuilder("IP");

            if (!string.IsNullOrWhiteSpace(config.Address))
                sb.Append(' ').Append("address ").Append(config.Address);

            if (!string.IsNullOrWhiteSpace(config.Netmask))
                sb.Append(' ').Append("netmask ").Append(config.Netmask);

            if (!string.IsNullOrWhiteSpace(config.Gateway))
                sb.Append(' ').Append("gateway ").Append(config.Gateway);

            if (!string.IsNullOrWhiteSpace(config.Hostname))
                sb.Append(' ').Append("hostname ").Append(config.Hostname);

            var response = await _connection.SendCommandAsync(sb.ToString(), cancellationToken)
                           ?? string.Empty;

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result<IpConfig>.Failure(response);

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

            var command = "SET " + string.Join(' ', parameters.Select(kv => $"{kv.Key}:{kv.Value}"));

            var response = await _connection.SendCommandAsync(command, cancellationToken)
                           ?? string.Empty;

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result.Failure(response);

            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"SET failed: {ex.Message}");
        }
    }
}
