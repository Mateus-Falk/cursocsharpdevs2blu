using Microsoft.EntityFrameworkCore;
using ProjetoContatos.API.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "ContatoCors",
					  policy =>
					  {
						  policy.WithOrigins("*")
						  .WithHeaders("*");
					  });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
	(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("ContatoCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
