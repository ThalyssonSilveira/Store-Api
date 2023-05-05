namespace Store.Platform.Business.Services.Models.Request;

public class UpdateProductRequest
{
    public long ProductId { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
}