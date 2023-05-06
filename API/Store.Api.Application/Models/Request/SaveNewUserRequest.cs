namespace Store.API.Application.Models.Request;

public class SaveNewUserRequest
{
    public string Login { get; set; }
    public string Password { get; set; }
}