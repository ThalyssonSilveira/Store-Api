using Store.Platform.Auth.Repository;
using Store.Platform.Auth.Factory.Repository;
using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Auth.Repository.Interfaces;
using Store.Platform.Auth.Factory.Repository.Interfaces;
using Store.Platform.Auth.Service.Interfaces;
using Store.Platform.Auth.Service;
using Store.Platform.Auth.Factory.Service.Interfaces;
using Store.Platform.Auth.Factory.Service;

namespace Store.Platform.Auth.Infrastructure.DependencyInjection;

internal class UserServiceCollection
{
    public static void AddScopedFactories(IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserServiceFactory, UserServiceFactory>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserRepositoryFactory, UserRepositoryFactory>();
    }
}
