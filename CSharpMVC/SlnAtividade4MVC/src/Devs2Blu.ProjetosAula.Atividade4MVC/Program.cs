using Devs2Blu.ProjetosAula.Atividade4MVC.Models;
using Devs2Blu.ProjetosAula.Atividade4MVC.Repository;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Implements;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context Db SQL Server
builder.Services.AddDbContext<ContextoDatabase>
    (options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS;Database=ListaDeJogos;User Id=sa;Password=zuky;TrustServerCertificate=True;"));

/*
 * Dependency Injection
 */ 

// Repositories
builder.Services.AddScoped<GeneroRepository,GeneroRepository>();
builder.Services.AddScoped<JogoRepository,JogoRepository>();
// Services
builder.Services.AddScoped<IGenerosService,GenerosServices>();
builder.Services.AddScoped<IJogosService,JogosServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
