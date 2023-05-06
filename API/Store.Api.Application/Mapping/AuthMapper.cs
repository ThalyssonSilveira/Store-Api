using Store.API.Application.Models.Request;
using AuthModelRequest = Store.Platform.Auth.Services.Models.Request;

namespace Store.Api.Application.Mapping;

public class AuthMapper
{
    public AuthModelRequest.AuthenticateRequest Map(AuthenticateRequest authenticateRequest)
    {
        return new AuthModelRequest.AuthenticateRequest()
        {
            Login = authenticateRequest.Login,
            Password = authenticateRequest.Password
        };
    }
}
