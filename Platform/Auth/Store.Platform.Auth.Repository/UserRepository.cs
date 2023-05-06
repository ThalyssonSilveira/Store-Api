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

}