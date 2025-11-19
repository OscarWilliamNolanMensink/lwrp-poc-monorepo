Yeah, totally agree: opening a second TCP connection just for VER/IP/SET is overkill — especially because LWRP expects you to LOGIN once and then reuse the same session.

Let’s refactor so:

There is one shared TCP connection to the mock device.

TcpLwrpLoginService and TcpLwrpDeviceInfoService both use that shared connection.

Once your /api/login succeeds, all later /api/ver, /api/ip, /api/settings calls use the same logged-in TCP session.

1. Introduce a shared connection abstraction
1.1 Create ILwrpConnection

In Lwrp.LivewireClient (same project as TcpLwrpLoginService), add:

namespace Lwrp.LivewireClient;

public interface ILwrpConnection : IAsyncDisposable
{
    /// <summary>
    /// Sends a single LWRP command and reads a single line response.
    /// </summary>
    Task<string> SendCommandAsync(string command, CancellationToken cancellationToken = default);
}

1.2 Implement LwrpTcpConnection

New file: LwrpTcpConnection.cs in Lwrp.LivewireClient:

using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Options;
using Lwrp.Contracts;

namespace Lwrp.LivewireClient;

public sealed class LwrpTcpConnection : ILwrpConnection
{
    private readonly LwrpConnectionOptions _options;

    private TcpClient? _client;
    private NetworkStream? _stream;
    private StreamReader? _reader;
    private StreamWriter? _writer;

    // Serialize access to one TCP connection across multiple requests
    private readonly SemaphoreSlim _lock = new(1, 1);

    public LwrpTcpConnection(IOptions<LwrpConnectionOptions> options)
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

    public async Task<string> SendCommandAsync(string command, CancellationToken cancellationToken = default)
    {
        await _lock.WaitAsync(cancellationToken);
        try
        {
            await EnsureConnectedAsync(cancellationToken);

            // LWRP is line-based ASCII
            await _writer!.WriteLineAsync(command);

            var line = await _reader!.ReadLineAsync();
            return line ?? string.Empty;
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


Key points:

It holds the single TcpClient / NetworkStream.

It’s thread-safe via SemaphoreSlim.

Everyone (login + VER/IP/SET) goes through SendCommandAsync.

2. Make TcpLwrpLoginService use ILwrpConnection

Replace your current TcpLwrpLoginService with this simplified version:

using Lwrp.Application.Auth;

namespace Lwrp.LivewireClient;

public sealed class TcpLwrpLoginService : ILwrpLoginService
{
    private readonly ILwrpConnection _connection;

    public TcpLwrpLoginService(ILwrpConnection connection)
    {
        _connection = connection;
    }

    public async Task<Result> LoginAsync(string password, CancellationToken cancellationToken = default)
    {
        try
        {
            var command = string.IsNullOrWhiteSpace(password)
                ? "LOGIN"
                : $"LOGIN {password}";

            var response = await _connection.SendCommandAsync(command, cancellationToken);

            // Interpret mock device responses
            if (response.StartsWith("LOGIN OK", StringComparison.OrdinalIgnoreCase))
                return Result.Success();

            if (response.StartsWith("LOGIN READONLY", StringComparison.OrdinalIgnoreCase))
                return Result.Failure("Login succeeded but only with read-only rights.");

            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                return Result.Failure(response);

            return Result.Failure($"Unexpected login response: '{response}'");
        }
        catch (Exception ex)
        {
            return Result.Failure($"Login failed: {ex.Message}");
        }
    }
}


No more TcpClient etc. here – just the shared connection.

3. Make TcpLwrpDeviceInfoService use the same connection

Now refactor TcpLwrpDeviceInfoService we wrote earlier to also depend on ILwrpConnection and drop its own TCP fields.

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
            var response = await _connection.SendCommandAsync("VER", cancellationToken);

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
                LwrpVersion: lwrp ?? string.Empty,
                DeviceName: devn ?? string.Empty,
                SystemVersion: sysv ?? string.Empty,
                NumberOfSources: nsrc,
                NumberOfDestinations: ndst,
                NumberOfGpi: ngpi,
                NumberOfGpo: ngpo
            );

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
            var response = await _connection.SendCommandAsync("IP", cancellationToken);

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
                Address: dict.GetValueOrDefault("address") ?? string.Empty,
                Netmask: dict.GetValueOrDefault("netmask") ?? string.Empty,
                Gateway: dict.GetValueOrDefault("gateway") ?? string.Empty,
                Hostname: dict.GetValueOrDefault("hostname") ?? string.Empty
            );

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

            var response = await _connection.SendCommandAsync(sb.ToString(), cancellationToken);

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
                Address: dict.GetValueOrDefault("address") ?? string.Empty,
                Netmask: dict.GetValueOrDefault("netmask") ?? string.Empty,
                Gateway: dict.GetValueOrDefault("gateway") ?? string.Empty,
                Hostname: dict.GetValueOrDefault("hostname") ?? string.Empty
            );

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

            var paramTokens = parameters.Select(kvp => $"{kvp.Key}:{kvp.Value}");
            var command = "SET " + string.Join(' ', paramTokens);

            var response = await _connection.SendCommandAsync(command, cancellationToken);

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


Note: all TcpClient bits are gone; everything goes via _connection.

4. Wire it up in Program.cs

Now you actually get the shared connection via DI.

Update Lwrp.Api/Program.cs to:

using Lwrp.Application.Auth;
using Lwrp.Application.Device;
using Lwrp.LivewireClient;
using Lwrp.Contracts;

var builder = WebApplication.CreateBuilder(args);

// LWRP connection options from config
builder.Services.Configure<LwrpConnectionOptions>(
    builder.Configuration.GetSection("Lwrp"));

// Shared TCP connection (one per app)
builder.Services.AddSingleton<ILwrpConnection, LwrpTcpConnection>();

// Login service uses shared connection
builder.Services.AddScoped<ILwrpLoginService, TcpLwrpLoginService>();

// VER/IP/SET service uses same shared connection
builder.Services.AddScoped<ILwrpDeviceInfoService, TcpLwrpDeviceInfoService>();

// Add services to the container.
builder.Services.AddControllers();

// Swagger & API explorer
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();


Important bits:

ILwrpConnection is Singleton → one TCP connection for the whole app.

Login + DeviceInfo services are Scoped → per HTTP request, but they share that single connection instance.

Sequence now is:

Client calls POST /api/login → TcpLwrpLoginService sends LOGIN ....

Same TCP session stays open and authenticated.

Later, client calls GET /api/ver, GET/PUT /api/ip, POST /api/settings → TcpLwrpDeviceInfoService sends VER / IP / SET over the same connection.

5. Mental model: what changed?

❌ Before: Each service had its own TcpClient → multiple connections, multiple logins.

✅ After: Single LwrpTcpConnection handles the socket; services just say “send this command, give me the line back”.

From your app’s point of view, you just:

Call /api/login once.

Then happily call /api/ver, /api/ip, /api/settings and they’re all on the same authenticated LWRP session.

If you want, next we can:

Add a simple IsLoggedIn flag in LwrpTcpConnection or a dedicated “session manager”, so TcpLwrpDeviceInfoService can fail fast if someone forgot to call /api/login first.