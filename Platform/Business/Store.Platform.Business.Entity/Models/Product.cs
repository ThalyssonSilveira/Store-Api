using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Platform.Business.Entity.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ProductId { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Name { get; set; }

    [Column(TypeName = "numeric(18,2)")]
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