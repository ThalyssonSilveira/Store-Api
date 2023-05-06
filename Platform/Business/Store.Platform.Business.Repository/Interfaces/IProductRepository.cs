using Store.Platform.Business.Entity.Models;

namespace Store.Platform.Business.Repository.Interfaces;

public interface IProductRepository
{
    public Product GetById(long productId);
    public List<Product> GetAll();
    public void SaveNewProduct(Product product);
    public void DeleteProduct(long productId);
    public void UpdateProduct(Product product);
}