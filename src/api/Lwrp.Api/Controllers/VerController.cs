using Lwrp.Application.Device;
using Microsoft.AspNetCore.Mvc;

namespace Lwrp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VerController : ControllerBase
{
    private readonly ILwrpDeviceInfoService _device;

    public VerController(ILwrpDeviceInfoService device)
    {
        _device = device;
    }

    public record VerResponseDto(
        string LwrpVersion,
        string DeviceName,
        string SystemVersion,
        int NumberOfSources,
        int NumberOfDestinations,
        int NumberOfGpi,
        int NumberOfGpo);

    [HttpGet]
    public async Task<ActionResult<VerResponseDto>> Get(CancellationToken cancellationToken)
    {
        var result = await _device.GetVersionAsync(cancellationToken);

        if (!result.IsSuccess || result.Value is null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { Success = false, Error = result.Error });
        }

        var v = result.Value;
        return Ok(new VerResponseDto(
            v.LwrpVersion,
            v.DeviceName,
            v.SystemVersion,
            v.NumberOfSources,
            v.NumberOfDestinations,
            v.NumberOfGpi,
            v.NumberOfGpo));
    }
}
