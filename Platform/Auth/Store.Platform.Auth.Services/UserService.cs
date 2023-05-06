using System.Text;
using System.Security.Claims;
using Store.Platform.Common.Entity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Store.Platform.Auth.Entity.Models;
using Store.Platform.Auth.Service.Mapping;
using Store.Platform.Auth.Service.Interfaces;
using Store.Platform.Auth.Services.Models.Result;
using Store.Platform.Auth.Services.Models.Request;
using Store.Platform.Auth.Factory.Repository.Interfaces;
using Store.Platform.Auth.Common;

namespace Store.Platform.Auth.Service;

public class UserService : IUserService
{

    private readonly IUserRepositoryFactory _userRepositoryFactory;
    private readonly Settings _settings;

    public UserService(IUserRepositoryFactory userRepositoryFactory, Settings settings)
    {
        _userRepositoryFactory = userRepositoryFactory;
        _settings = settings;
    }

    public void SaveNewUser(SaveNewUserRequest saveNewUserRequest)
    {
        User newUser = User.Create(saveNewUserRequest.Login, saveNewUserRequest.Password);

        _userRepositoryFactory.Create().SaveNewUser(newUser);
    }
}
