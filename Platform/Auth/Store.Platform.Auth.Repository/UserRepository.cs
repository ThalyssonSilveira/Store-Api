using Dapper;
using Microsoft.Data.SqlClient;
using Store.Platform.Auth.Entity.Models;
using Store.Platform.Auth.Repository.Interfaces;
using Store.Platform.Common.Entity;

namespace Store.Platform.Auth.Repository;

public class UserRepository : IUserRepository
{
    private readonly Settings _settings;

    public UserRepository(Settings settings)
    {
        _settings = settings;
    }

    public User GetByLogin(string login)
    {
        using var connection = new SqlConnection(_settings.ConnectionStrings["DefaultConnection"]);
        try
        {
            User user = connection.QueryFirst<User>("SELECT * FROM [User] WHERE Login = @Login", new { Login = login });

            return user;
        }
        catch
        {
            return null;
        }
    }

}