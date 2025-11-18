using Lwrp.Contracts;
// Making this a consumer file.
namespace Lwrp.Application.Auth;

public interface ILwrpLoginService
{
    Task<Result> LoginAsync(string password, CancellationToken cancellationToken = default);
}
