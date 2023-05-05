using Microsoft.Extensions.DependencyInjection;
using Store.Platform.Business.Factory.Service.Interfaces;
using Store.Platform.Business.Service.Interfaces;

namespace Store.Platform.Business.Factory.Service;

public class ProductServiceFactory : IProductServiceFactory
{
    private IServiceProvider _provider;

    public ProductServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public IProductService Create() => _provider.GetService<IProductService>();
}
