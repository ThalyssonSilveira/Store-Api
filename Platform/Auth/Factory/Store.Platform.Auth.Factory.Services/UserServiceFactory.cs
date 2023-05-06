using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Auth.Factory.Service.Interfaces;
using Store.Platform.Auth.Service.Interfaces;

namespace Store.Platform.Auth.Factory.Service;

public class UserServiceFactory : IUserServiceFactory
{
    private IServiceProvider _provider;

    public UserServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IUserService Create() => _provider.GetService<IUserService>();
}
