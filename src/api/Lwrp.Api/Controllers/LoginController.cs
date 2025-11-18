using Lwrp.Application.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Lwrp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly ILwrpLoginService _loginService;

    public LoginController(ILwrpLoginService loginService)
    {
        _loginService = loginService;
    }

    public record LoginRequestDto(string? Password);
    public record LoginResponseDto(bool Success, string? Error);

    [HttpPost]
    public async Task<ActionResult<LoginResponseDto>> Login(
        [FromBody] LoginRequestDto request,
        CancellationToken cancellationToken)
    {
        var password = request.Password ?? string.Empty;

        var result = await _loginService.LoginAsync(password, cancellationToken);

        if (!result.IsSuccess)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new LoginResponseDto(false, result.Error));
        }

        return Ok(new LoginResponseDto(true, null));
    }
}
