using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Application.Mapping;
using Store.Api.Application.Models.Response;
using Store.API.Application.Models.Request;
using Store.Platform.Business.Factory.Service.Interfaces;
using Store.Platform.Business.Services.Models.Result;
using BusinessModelRequest = Store.Platform.Business.Services.Models.Request;

namespace Store.API.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{


    public AuthController(IProductServiceFactory productServiceFactory)
    {

    }

    [HttpPost("[action]")]
    public IActionResult Authenticate([FromBody] AuthenticateRequest AuthenticateRequest)
    {


        return Ok();
    }


}
