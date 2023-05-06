using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Application.Mapping;
using Store.Api.Application.Models.Response;
using Store.API.Application.Models.Request;
using Store.Platform.Auth.Services.Models.Result;
using AuthModelRequest = Store.Platform.Auth.Services.Models.Request;

namespace Store.API.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    public AuthController()
    {

    }

    [AllowAnonymous]
    [HttpPost("[action]")]
    public IActionResult Authenticate([FromBody] AuthenticateRequest AuthenticateRequest)
    {


        return Ok();
    }


}
