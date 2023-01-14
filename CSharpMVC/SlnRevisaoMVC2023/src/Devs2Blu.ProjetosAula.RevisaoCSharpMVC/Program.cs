using Devs2Blu.ProjetosAula.RevisaoCSharpMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context DB SQL Server
builder.Services.AddDbContext<ContextoDatabase>
    (options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS;Database=NoticiasF1;User Id=sa;Password=zuky; TrustServerCertificate=True;"));

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
    pattern: "{controller=Noticias}/{action=Home}/{id?}");

app.Run();
