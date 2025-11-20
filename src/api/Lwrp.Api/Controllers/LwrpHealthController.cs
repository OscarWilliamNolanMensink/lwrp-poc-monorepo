using Lwrp.Application.Device;
using Microsoft.AspNetCore.Mvc;
using Lwrp.Contracts;

namespace Lwrp.Api.Controllers;

[ApiController]
[Route("api/lwrp/health")]
public class LwrpHealthController : ControllerBase
{
    private readonly ILwrpDeviceInfoService _deviceInfo;

    public LwrpHealthController(ILwrpDeviceInfoService deviceInfo)
    {
        _deviceInfo = deviceInfo;
    }

    [HttpGet]
    public async Task<ActionResult<ConnectionStatusDto>> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _deviceInfo.GetVersionAsync(cancellationToken);

            if (!result.IsSuccess) // 👈 use the bool property, not the static method
            {
                return Ok(new ConnectionStatusDto(
                    IsHealthy: false,
                    Message: result.Error ?? "Unknown error",
                    CheckedAt: DateTimeOffset.UtcNow));
            }

            var info = result.Value; // or result.Value! depending on your Result<T> API

            return Ok(new ConnectionStatusDto(
                IsHealthy: true,
                Message: $"Connected to {info.DeviceName} (LWRP {info.LwrpVersion})",
                CheckedAt: DateTimeOffset.UtcNow));
        }
        catch (Exception ex)
        {
            return Ok(new ConnectionStatusDto(
                IsHealthy: false,
                Message: $"Exception: {ex.Message}",
                CheckedAt: DateTimeOffset.UtcNow));
        }
    }

}
