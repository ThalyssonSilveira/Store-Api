using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Auth.Factory.Service;
using Store.Platform.Auth.Factory.Repository.Interfaces;
using Store.Platform.Auth.Factory.Service.Interfaces;
using Store.Platform.Auth.Repository.Interfaces;
using Store.Platform.Auth.Service;
using Store.Platform.Auth.Service.Interfaces;
using Store.Platform.Auth.Repository;
using Store.Platform.Auth.Factory.Repository;

namespace Store.Platform.Auth.Infrastructure.DependencyInjection;

internal class AuthServiceCollection
{
    public static void AddScopedFactories(IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IAuthServiceFactory, AuthServiceFactory>();
    }
}
