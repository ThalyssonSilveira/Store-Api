using Store.API.Application.Models.Request;
using BusinessModelRequest = Store.Platform.Business.Services.Models.Request;

namespace Store.Api.Application.Mapping;

public class ProductMapper
{
    public BusinessModelRequest.SaveNewProductRequest Map(SaveNewProductRequest saveNewProductRequest)
    {
        return new BusinessModelRequest.SaveNewProductRequest()
        {
            Name = saveNewProductRequest.Name,
            Value = saveNewProductRequest.Value
        };
    }

    public BusinessModelRequest.UpdateProductRequest Map(UpdateProductRequest updateProductRequest)
    {
        return new BusinessModelRequest.UpdateProductRequest()
        {
            ProductId = updateProductRequest.ProductId,
            Name = updateProductRequest.Name,
            Value = updateProductRequest.Value
        };
    }
}
