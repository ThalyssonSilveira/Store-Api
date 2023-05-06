using Store.API.Application.Models.Request;
using AuthModelRequest = Store.Platform.Auth.Services.Models.Request;

namespace Store.Api.Application.Mapping;

public class UserMapper
{
    public AuthModelRequest.SaveNewUserRequest Map(SaveNewUserRequest saveNewUserRequest)
    {
        return new AuthModelRequest.SaveNewUserRequest()
        {
            Login = saveNewUserRequest.Login,
            Password = saveNewUserRequest.Password
        };
    }
}
