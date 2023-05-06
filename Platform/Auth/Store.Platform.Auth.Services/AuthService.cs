using Store.Platform.Auth.Entity.Models;
using Store.Platform.Auth.Factory.Repository.Interfaces;
using Store.Platform.Auth.Service.Interfaces;
using Store.Platform.Auth.Service.Mapping;
using Store.Platform.Auth.Services.Models.Request;
using Store.Platform.Auth.Services.Models.Result;
using Store.Platform.Common.Entity;

namespace Store.Platform.Auth.Service;

public class AuthService : IAuthService
{
    private readonly AuthMapper _authMapper;
    private readonly IUserRepositoryFactory _userRepositoryFactory;
    private readonly Settings _settings;

    public AuthService(IUserRepositoryFactory userRepositoryFactory, Settings settings)
    {
        _authMapper = new AuthMapper();
        _userRepositoryFactory = userRepositoryFactory;
        _settings = settings;
    }
}
