using Store.Platform.Business.Common;
using Store.Platform.Business.Entity.Models;
using Store.Platform.Business.Factory.Repository.Interfaces;
using Store.Platform.Business.Service.Interfaces;
using Store.Platform.Business.Service.Mapping;
using Store.Platform.Business.Services.Models.Request;
using Store.Platform.Business.Services.Models.Result;
using Store.Platform.Common.Entity;

namespace Store.Platform.Business.Service;

public class ProductService : IProductService
{
    private readonly ProductMapper _productMapper;
    private readonly IProductRepositoryFactory _productRepositoryFactory;
    private readonly Settings _settings;

    public ProductService(IProductRepositoryFactory productRepositoryFactory, Settings settings)
    {
        _productMapper = new ProductMapper();
        _productRepositoryFactory = productRepositoryFactory;
        _settings = settings;
    }

    public GetProductByIdResult GetById(long productId)
    {
        Product product = _productRepositoryFactory.Create().GetById(productId);

        if (product == null)
            throw new BusinessException("Produto não encontrado");

        GetProductByIdResult productResult = _productMapper.Map(product);

        return productResult;
    }

    public GetProductListResult GetAll()
    {
        List<Product> productList = _productRepositoryFactory.Create().GetAll();

        GetProductListResult getProductListResult = _productMapper.Map(productList);

        return getProductListResult;
    }

    public void SaveNewProduct(SaveNewProductRequest saveNewProductRequest)
    {
        Product newProduct = Product.Create(saveNewProductRequest.Name, saveNewProductRequest.Value);

        _productRepositoryFactory.Create().SaveNewProduct(newProduct);
    }

    public void DeleteProduct(long productId)
    {
        _productRepositoryFactory.Create().DeleteProduct(productId);
    }

    public void UpdateProduct(UpdateProductRequest updateProductRequest)
    {
        Product getProdcut = _productRepositoryFactory.Create().GetById(updateProductRequest.ProductId);

        getProdcut.Name = updateProductRequest.Name;
        getProdcut.Value = updateProductRequest.Value;

        _productRepositoryFactory.Create().UpdateProduct(getProdcut);
    }
}
