using Dapper;
using Microsoft.Data.SqlClient;
using Store.Platform.Business.Entity;
using Store.Platform.Business.Repository.Interfaces;
using Store.Platform.Common.Entity;

namespace Store.Platform.Business.Repository;

public class ProductRepository : IProductRepository
{
    private readonly Settings _settings;

    public ProductRepository(Settings settings)
    {
        _settings = settings;
    }

    public Product GetById(long productId)
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        Product getProductById = connection.QueryFirst<Product>("SELECT * FROM Product WHERE ProductId = @Id", new { Id = productId });

        return getProductById;
    }

    public List<Product> GetAll()
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        IEnumerable<Product> producList = connection.Query<Product>("SELECT * FROM Product");

        return producList.ToList<Product>();
    }

    public void SaveNewProduct(Product product)
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        connection.Execute("INSERT INTO Product (Name, Value) VALUES (@Name, @Value)", product);
    }

    public void DeleteProduct(long productId)
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        connection.Execute("DELETE FROM Product WHERE ProductId = @ProductId", new { Id = productId });
    }

    public void UpdateProduct(Product product)
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        connection.Execute("UPDATE Product SET Name = @Name, Value = @Value WHERE ProductId = @ProductId", product);
    }
}