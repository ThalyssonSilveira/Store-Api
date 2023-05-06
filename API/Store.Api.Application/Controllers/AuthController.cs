using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Application.Mapping;
using Store.Api.Application.Models.Response;
using Store.API.Application.Models.Request;
using Store.Platform.Auth.Factory.Service.Interfaces;
using Store.Platform.Auth.Services.Models.Result;
using AuthModelRequest = Store.Platform.Auth.Services.Models.Request;

namespace Store.API.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthServiceFactory _authServiceFactory;
    private readonly AuthMapper _authMapper;
    public AuthController(IAuthServiceFactory authServiceFactory)
    {
        _authServiceFactory = authServiceFactory;
        _authMapper = new AuthMapper();
    }

    [AllowAnonymous]
    [HttpPost("[action]")]
    public IActionResult Authenticate([FromBody] AuthenticateRequest AuthenticateRequest)
    {
        AuthModelRequest.AuthenticateRequest authModelRequest = _authMapper.Map(AuthenticateRequest);

        AuthenticateResult result = _authServiceFactory.Create().Authenticate(authModelRequest);

        Response response = ResponseMapper.Map(true, result, null);

        return Ok(response);
    }


}
