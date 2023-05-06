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

    public AuthenticateResult Authenticate(AuthenticateRequest authenticateRequest)
    {
        User user = _userRepositoryFactory.Create().GetByLogin(authenticateRequest.Login);

        if (user == null)
            throw new AuthException("Usuário não encontrado");
        else
        {
            if (user.Password != authenticateRequest.Password)
                throw new AuthException("Senha incorreta");

            string jwtToken = GenerateJwtToken(authenticateRequest, user.UserId.ToString());

            AuthenticateResult authenticateResult = _authMapper.Map(jwtToken);

            return authenticateResult;
        }
    }

    private string GenerateJwtToken(AuthenticateRequest authenticateRequest, string userId)
    {
        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

        byte[] key = Encoding.ASCII.GetBytes(_settings.JwtSecret);
        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                    new Claim(ClaimTypes.Name, authenticateRequest.Login),
                    new Claim(ClaimTypes.NameIdentifier, userId),
                    new Claim(ClaimTypes.Role, "default")
            }),
            Expires = DateTime.UtcNow.AddMinutes(_settings.JwtExpirationTime),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
