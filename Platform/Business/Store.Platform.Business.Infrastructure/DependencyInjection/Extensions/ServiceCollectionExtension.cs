using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Business.Infrastructure.DependencyInjection;

namespace Store.Platform.Business.Infrastructure.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddScopedBusinessFactories(this IServiceCollection services)
    {
        ProductServiceCollection.AddScopedFactories(services);
    }

}
