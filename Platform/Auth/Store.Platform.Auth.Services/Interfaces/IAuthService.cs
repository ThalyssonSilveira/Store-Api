using Store.Platform.Auth.Entity;
using Store.Platform.Auth.Services.Models.Request;
using Store.Platform.Auth.Services.Models.Result;

namespace Store.Platform.Auth.Service.Interfaces
{
    public interface IAuthService
    {
        public AuthenticateResult Authenticate(AuthenticateRequest authenticateRequest);
    }
}