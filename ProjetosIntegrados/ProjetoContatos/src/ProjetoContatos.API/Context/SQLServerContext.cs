using Microsoft.EntityFrameworkCore;
using ProjetoContatos.API.Entities;

namespace ProjetoContatos.API.Context
{
	public class SQLServerContext : DbContext
	{
		public SQLServerContext(DbContextOptions<SQLServerContext> options)
			: base(options)
		{
		
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Contato>()
				.HasData(
				new {Id = 1, Nome = "Tuca", Telefone = "(47) 99457-8964", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 2, Nome = "Mel", Telefone = "(47) 99657-8212", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 3, Nome = "Zuky", Telefone = "(47) 99123-8785", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 4, Nome = "Bidu", Telefone = "(47) 99932-7452", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 5, Nome = "Lilica", Telefone = "(47) 99445-6787", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 6, Nome = "Nickolas", Telefone = "(47) 99985-8554", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 7, Nome = "Nanica", Telefone = "(47) 99457-8545", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 8, Nome = "Peta", Telefone = "(47) 99145-1225", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"},
				new {Id = 9, Nome = "Mingui", Telefone = "(47) 99487-5412", Estado = "SC", Cidade = "Blumenau", Bairro = "Vila Itoupava"}
				);
		}

		#region DbSets<Tables>
		public DbSet<Contato> Contatos { get; set; }
		#endregion
	}
}
