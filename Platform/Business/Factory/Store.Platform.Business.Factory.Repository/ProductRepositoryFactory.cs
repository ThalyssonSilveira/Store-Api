using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Business.Factory.Repository.Interfaces;
using Store.Platform.Business.Repository.Interfaces;

namespace Store.Platform.Business.Factory.Repository;

public class ProductRepositoryFactory : IProductRepositoryFactory
{
    private IServiceProvider _provider;

    public ProductRepositoryFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IProductRepository Create() => _provider.GetService<IProductRepository>();
}
