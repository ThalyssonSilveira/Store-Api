namespace Store.API.Application.Models.Request;

public class AuthenticateRequest
{
    public string Login { get; set; }
    public string Password { get; set; }
}