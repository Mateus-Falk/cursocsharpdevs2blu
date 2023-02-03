using Devs2Blu.APIFilmes.Application.Services.SQLServerServices;
using Devs2Blu.APIFilmes.Domain.IRepositories;
using Devs2Blu.APIFilmes.Domain.IServices;
using Devs2Blu.APIFilmes.Infra.Data.Context;
using Devs2Blu.APIFilmes.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context SQL Server

builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS;Database=MoviesAPI;User Id=sa;Password=zuky;TrustServerCertificate=True;Encrypt=False;"));

// ### Dependecy Injection
// # Repositories
builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

// # Services
builder.Services.AddScoped<IMoviesService, MoviesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
