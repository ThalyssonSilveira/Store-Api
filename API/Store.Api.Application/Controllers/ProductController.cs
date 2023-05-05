using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Api.Application.Mapping;
using Store.Api.Application.Models.Response;
using Store.API.Application.Models.Request;
using Store.Platform.Business.Factory.Service.Interfaces;
using Store.Platform.Business.Services.Models.Result;
using BusinessModelRequest = Store.Platform.Business.Services.Models.Request;

namespace Store.API.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductServiceFactory _productServiceFactory;
    private readonly ProductMapper _productMapper;

    public ProductController(IProductServiceFactory productServiceFactory)
    {
        _productServiceFactory = productServiceFactory;
        _productMapper = new ProductMapper();
    }

    [HttpGet("[action]/{id}")]
    public IActionResult GetById(long id)
    {
        GetProductByIdResult productByIdResult = _productServiceFactory.Create().GetById(id);

        Response response = ResponseMapper.Map(true, productByIdResult, null);

        return Ok(response);
    }

    [HttpGet("[action]")]
    public IActionResult GetAll()
    {
        GetProductListResult getProductListResult = _productServiceFactory.Create().GetAll();

        Response response = ResponseMapper.Map(true, getProductListResult, null);

        return Ok(response);
    }

    [HttpPost()]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult POST([FromBody] SaveNewProductRequest saveNewProductRequest)
    {
        BusinessModelRequest.SaveNewProductRequest businessModelRequest = _productMapper.Map(saveNewProductRequest);
        _productServiceFactory.Create().SaveNewProduct(businessModelRequest);
        return NoContent();
    }

    [HttpPut()]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult PUT([FromBody] UpdateProductRequest updateProductRequest)
    {
        BusinessModelRequest.UpdateProductRequest businessModelRequest = _productMapper.Map(updateProductRequest);
        _productServiceFactory.Create().UpdateProduct(businessModelRequest);
        return Ok();
    }

    [HttpDelete("{id}")]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public IActionResult DELETE(long id)
    {
        _productServiceFactory.Create().DeleteProduct(id);
        return NoContent();
    }
}
