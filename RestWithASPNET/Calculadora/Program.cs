using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RestWithASPNET.Model.Services.Implementations;
using RestWithASPNET.Model.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
