using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<PortfolioContext>(options =>
    options.UseSqlite("Data Source=portfolio.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200", "http://localhost:4201")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Migrate and seed DB
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PortfolioContext>();
    db.Database.Migrate();
}

app.MapOpenApi();
app.MapScalarApiReference(options =>
{
    options.Title = "Portfolio API – AMAL Ben Abdelghaffar";
    options.Theme = ScalarTheme.Purple;
});

app.UseCors("AllowAngular");
app.UseAuthorization();
app.MapControllers();

app.Run();
