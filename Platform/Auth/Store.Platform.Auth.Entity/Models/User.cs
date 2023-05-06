using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Platform.Auth.Entity.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long UserId { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Login { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Password { get; set; }

    public static User Create(string login, string password)
    {
        return new User()
        {
            Login = login,
            Password = password
        };
    }
}