namespace Store.API.Application.Models.Request;

public class UpdateProductRequest
{
    public long ProductId { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
}