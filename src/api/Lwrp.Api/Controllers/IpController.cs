using Lwrp.Application.Device;
using Lwrp.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Lwrp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IpController : ControllerBase
{
    private readonly ILwrpDeviceInfoService _device;

    public IpController(ILwrpDeviceInfoService device)
    {
        _device = device;
    }

    public record IpConfigResponseDto(
        string Address,
        string Netmask,
        string Gateway,
        string Hostname);

    public record IpConfigRequestDto(
        string Address,
        string Netmask,
        string Gateway,
        string Hostname);

    [HttpGet]
    public async Task<ActionResult<IpConfigResponseDto>> Get(CancellationToken cancellationToken)
    {
        var result = await _device.GetIpConfigAsync(cancellationToken);

        if (!result.IsSuccess || result.Value is null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { Success = false, Error = result.Error });
        }

        var ip = result.Value;

        return Ok(new IpConfigResponseDto(
            ip.Address,
            ip.Netmask,
            ip.Gateway,
            ip.Hostname));
    }

    [HttpPut]
    public async Task<ActionResult<IpConfigResponseDto>> Put(
        [FromBody] IpConfigRequestDto request,
        CancellationToken cancellationToken)
    {
        var config = new IpConfig(
            request.Address,
            request.Netmask,
            request.Gateway,
            request.Hostname);

        var result = await _device.SetIpConfigAsync(config, cancellationToken);

        if (!result.IsSuccess || result.Value is null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { Success = false, Error = result.Error });
        }

        var ip = result.Value;

        return Ok(new IpConfigResponseDto(
            ip.Address,
            ip.Netmask,
            ip.Gateway,
            ip.Hostname));
    }
}
