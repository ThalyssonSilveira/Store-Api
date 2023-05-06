using Microsoft.AspNetCore.Mvc;
using Store.Api.Application.Mapping;
using Store.API.Application.Models.Request;
using Store.Platform.Auth.Factory.Service.Interfaces;
using AuthModelRequest = Store.Platform.Auth.Services.Models.Request;

namespace Store.API.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserServiceFactory _userServiceFactory;
    private readonly UserMapper _userMapper;

    public UserController(IUserServiceFactory userServiceFactory)
    {
        _userServiceFactory = userServiceFactory;
        _userMapper = new UserMapper();
    }


    [HttpPost()]
    public IActionResult POST([FromBody] SaveNewUserRequest saveNewUserRequest)
    {
        AuthModelRequest.SaveNewUserRequest authModelRequest = _userMapper.Map(saveNewUserRequest);
        _userServiceFactory.Create().SaveNewUser(authModelRequest);
        return NoContent();
    }
}
