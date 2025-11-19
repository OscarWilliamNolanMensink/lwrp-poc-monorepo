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

            var response = await _connection.SendCommandAsync(command, cancellationToken);

            // If your mock returns "ERROR <msg>" uncomment this:
            // if (response?.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase) == true)
            //     return Result.Failure(response);

            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure($"Login failed: {ex.Message}");
        }
    }
}
