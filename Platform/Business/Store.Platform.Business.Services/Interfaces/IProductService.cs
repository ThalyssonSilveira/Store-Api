using Store.Platform.Business.Entity;
using Store.Platform.Business.Services.Models.Request;
using Store.Platform.Business.Services.Models.Result;

namespace Store.Platform.Business.Service.Interfaces
{
    public interface IProductService
    {
        GetProductByIdResult GetById(long productId);
        GetProductListResult GetAll();
        void SaveNewProduct(SaveNewProductRequest saveNewProductRequest);
        public void DeleteProduct(long productId);
        public void UpdateProduct(UpdateProductRequest updateProductRequest);
    }
}