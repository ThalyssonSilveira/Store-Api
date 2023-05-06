namespace Store.Platform.Auth.Entity.Models;

public class User
{
    public long UserId { get; set; }
    public string Login { get; set; }
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