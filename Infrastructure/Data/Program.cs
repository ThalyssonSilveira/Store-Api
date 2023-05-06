using Store.Platform.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Store.Infrastructure.Data.DAL;

var builder = WebApplication.CreateBuilder(args);

Settings settings = builder.Configuration.GetSection("Settings").Get<Settings>();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
);

var app = builder.Build();

app.Run();