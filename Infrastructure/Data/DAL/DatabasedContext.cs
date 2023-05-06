using Microsoft.EntityFrameworkCore;
using Store.Platform.Auth.Entity.Models;
using Store.Platform.Business.Entity.Models;

namespace Store.Infrastructure.Data.DAL;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }

}