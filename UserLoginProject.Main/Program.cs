using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using UserLoginProject.Infra.Database.Helpers;
using UserLoginProject.Main.Config;
using UserLoginProject.Main.Factories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
new AuthenticationTokenConfig().AuthenticationToken(builder);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("dbTest"));
builder.Services
    .AddInfra()
    .AddDomain()
    .AddApplication();

builder.Services.AddSwaggerGen(setup => {
    new SwaggerAuthenticationConfig().SwaggerAuthentication(setup);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
