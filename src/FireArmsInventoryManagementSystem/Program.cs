using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using FireArmsInventoryManagementSystem.Mapping;
using FireArmsInventoryManagementSystem.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ------------------------------------------------------------
// Configuration
// ------------------------------------------------------------
builder.Configuration
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json",
                     optional: true, reloadOnChange: true)
       .AddUserSecrets<Program>(optional: true, reloadOnChange: true)
       .AddEnvironmentVariables();

// ------------------------------------------------------------
// Services
// ------------------------------------------------------------
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<FirearmsInventoryDB>(options =>
        options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(Form4473MappingProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FireArms Inventory Management System API",
        Version = "v1",
        Description = "HTTP API for 4473 processing & bound‑book operations"
    });
    // optional extras go here…
});      // ← closes AddSwaggerGen

builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "FireArmsInventoryManagementSystem API";
    config.Version = "v1"; // ✅ Required
    config.DocumentName = "v1";
    config.Description = "API documentation for FireArmsInventoryManagementSystem";
});


// ------------------------------------------------------------
// Build & middleware
// ------------------------------------------------------------
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                                   // serves /swagger/v1/swagger.json
    app.UseSwaggerUI(ui =>
    {
        ui.SwaggerEndpoint("/swagger/v1/swagger.json", "FIMS API v1");
        ui.DocumentTitle = "FIMS API Explorer";
        // ui.RoutePrefix = string.Empty;   // uncomment to land on Swagger at site root
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
