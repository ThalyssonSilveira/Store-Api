namespace Store.Platform.Auth.Services.Models.Request;

public class SaveNewUserRequest
{
    public string Login { get; set; }
    public string Password { get; set; }
}