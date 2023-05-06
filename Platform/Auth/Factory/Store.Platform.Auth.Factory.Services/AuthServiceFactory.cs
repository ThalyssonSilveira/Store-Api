using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Auth.Factory.Service.Interfaces;
using Store.Platform.Auth.Service.Interfaces;

namespace Store.Platform.Auth.Factory.Service;

public class AuthServiceFactory : IAuthServiceFactory
{
    private IServiceProvider _provider;

    public AuthServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IAuthService Create() => _provider.GetService<IAuthService>();
}
