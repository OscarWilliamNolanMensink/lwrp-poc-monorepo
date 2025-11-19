using Lwrp.Application.Auth;
using Lwrp.Contracts;

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

            var response = await _connection.SendCommandAsync(command, cancellationToken)
                           ?? string.Empty;

            // If your mock / device returns error lines, handle them here
            if (response.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
            {
                return Result.Failure(response);
            }

            // Only remember password when a password was actually used.
            // (If you support read-only LOGIN without password, you can
            // extend ILwrpConnection to remember that mode too.)
            if (!string.IsNullOrWhiteSpace(password))
            {
                _connection.RememberPassword(password);
            }

            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"Login failed: {ex.Message}");
        }
    }
}
