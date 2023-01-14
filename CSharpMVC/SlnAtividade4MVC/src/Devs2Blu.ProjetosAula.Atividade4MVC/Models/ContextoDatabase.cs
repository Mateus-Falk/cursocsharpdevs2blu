using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Jogo>()
                .HasOne(j => j.Genero)
                .WithMany(g => g.Jogo)
                .HasForeignKey(j => j.GeneroId);

            // Seed
            modelBuilder.Entity<Genero>()
                .HasData(
                new { Id = 1, Nome = "Ação/Aventura"},
                new { Id = 2, Nome = "Corrida"},
                new { Id = 3, Nome = "Esporte"},
                new { Id = 4, Nome = "FPS"},
                new { Id = 5, Nome = "RPG"},
                new { Id = 6, Nome = "Plataforma"},
                new { Id = 7, Nome = "Terror"}
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        #endregion
    }
}
