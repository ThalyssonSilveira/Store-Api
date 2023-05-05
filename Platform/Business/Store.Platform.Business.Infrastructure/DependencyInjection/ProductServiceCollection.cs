using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Business.Factory.Service;
using Store.Platform.Business.Factory.Repository.Interfaces;
using Store.Platform.Business.Factory.Service.Interfaces;
using Store.Platform.Business.Repository.Interfaces;
using Store.Platform.Business.Service;
using Store.Platform.Business.Service.Interfaces;
using Store.Platform.Business.Repository;
using Store.Platform.Business.Factory.Repository;

namespace Store.Platform.Business.Infrastructure.DependencyInjection;

internal class ProductServiceCollection
{
    public static void AddScopedFactories(IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductServiceFactory, ProductServiceFactory>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductRepositoryFactory, ProductRepositoryFactory>();
    }
}
