namespace Store.Platform.Business.Entity;

public class Product
{
    public long ProductId { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }

    public static Product Create(string name, double value)
    {
        return new Product()
        {
            Name = name,
            Value = value
        };
    }
}