using Devs2Blu.ProjetosAula.RevisaoCSharpMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.RevisaoCSharpMVC.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Noticia>()
                .HasOne(n => n.Categoria)
                .WithMany(c => c.Noticias)
                .HasForeignKey(n => n.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new {Id = 1, Nome = "Diversos"},
                new {Id = 2, Nome = "Equipes"},
                new {Id = 3, Nome = "Janela de Transferencias"},
                new {Id = 4, Nome = "Resultados"}
                );
            base.OnModelCreating(modelBuilder);
        }
        #region DBSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Noticia> Noticia { get; set; }
        #endregion
    }
}
