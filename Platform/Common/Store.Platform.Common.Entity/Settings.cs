namespace Store.Platform.Common.Entity;

public class Settings
{
    public IDictionary<string, string> ConnectionStrings { get; set; }
    public string JwtSecret { get; set; }
}
