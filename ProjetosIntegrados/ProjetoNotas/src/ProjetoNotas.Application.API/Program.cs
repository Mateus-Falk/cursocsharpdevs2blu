using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Application.Service.SQLServices;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using ProjetoNotas.Infra.Data.Repository.Context;
using ProjetoNotas.Infra.Data.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
   (options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS;Database=ProjetoNotas;User Id=sa;Password=zuky;TrustServerCertificate=True;Encrypt=False;"));

// Dependency Injection
// Repositories
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<INoteRepository,NoteRepository>();
// Services
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<INoteService,NoteService>();

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
