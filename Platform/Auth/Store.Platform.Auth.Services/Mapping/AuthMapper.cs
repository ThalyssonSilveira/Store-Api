using Store.Platform.Auth.Services.Models.Result;

namespace Store.Platform.Auth.Service.Mapping;

public class AuthMapper
{

    public AuthenticateResult Map(string jwtToken)
    {
        return new AuthenticateResult
        {
            JwtToken = jwtToken
        };
    }

}
