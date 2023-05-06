using Store.Platform.Business.Entity.Models;

namespace Store.Platform.Business.Services.Models.Result;

public class GetProductListResult
{
    public List<Product> ProductList { get; set; }
}