using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Context
{
	public class SQLServerContext : DbContext
	{
		public SQLServerContext(DbContextOptions<SQLServerContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Seed
			modelBuilder.Entity<User>()
				.HasData(
				new { Id = 1, Name = "Tuca", Login = "tuca", Password = "123456" }
				);
		}

		#region DbSets<Tables>
		public DbSet<Note> Notes { get; set; }
		public DbSet<User> Users { get; set; }
		#endregion
	}
}
