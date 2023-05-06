
using Store.Platform.Business.Entity.Models;
using Store.Platform.Business.Services.Models.Result;

namespace Store.Platform.Business.Service.Mapping;

public class ProductMapper
{
    public GetProductByIdResult Map(Product product)
    {
        return new GetProductByIdResult
        {
            Name = product.Name,
            Value = product.Value
        };
    }

    public GetProductListResult Map(List<Product> productList)
    {
        return new GetProductListResult
        {
            ProductList = productList
        };
    }
}
