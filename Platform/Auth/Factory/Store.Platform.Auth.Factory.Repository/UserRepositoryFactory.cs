using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Auth.Factory.Repository.Interfaces;
using Store.Platform.Auth.Repository.Interfaces;

namespace Store.Platform.Auth.Factory.Repository;

public class UserRepositoryFactory : IUserRepositoryFactory
{
    private IServiceProvider _provider;

    public UserRepositoryFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IUserRepository Create() => _provider.GetService<IUserRepository>();
}
