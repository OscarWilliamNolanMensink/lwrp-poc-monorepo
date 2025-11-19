using Lwrp.Contracts;

namespace Lwrp.Application.Device;

public interface ILwrpDeviceInfoService
{
    Task<Result<VerInfo>> GetVersionAsync(CancellationToken cancellationToken = default);

    Task<Result<IpConfig>> GetIpConfigAsync(CancellationToken cancellationToken = default);

    Task<Result<IpConfig>> SetIpConfigAsync(
        IpConfig config,
        CancellationToken cancellationToken = default);

    Task<Result> SetGlobalParametersAsync(
        IDictionary<string, string> parameters,
        CancellationToken cancellationToken = default);
}
