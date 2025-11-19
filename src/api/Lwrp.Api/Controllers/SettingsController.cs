using Lwrp.Application.Device;
using Microsoft.AspNetCore.Mvc;

namespace Lwrp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SettingsController : ControllerBase
{
    private readonly ILwrpDeviceInfoService _device;

    public SettingsController(ILwrpDeviceInfoService device)
    {
        _device = device;
    }

    public record SetRequestDto(IDictionary<string, string> Parameters);
    public record SetResponseDto(bool Success, string? Error);

    [HttpPost]
    public async Task<ActionResult<SetResponseDto>> Set(
        [FromBody] SetRequestDto request,
        CancellationToken cancellationToken)
    {
        var result = await _device.SetGlobalParametersAsync(request.Parameters, cancellationToken);

        if (!result.IsSuccess)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new SetResponseDto(false, result.Error));
        }

        return Ok(new SetResponseDto(true, null));
    }
}
