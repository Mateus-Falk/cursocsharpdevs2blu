using Devs2Blu.ProjetosAula.MVCSQLServerApp2v2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2v2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options) 
        {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          /*  modelBuilder.Entity<Jogo>()
                .HasOne(j => j.Genero)
                .WithMany(g => g.Jogos);*/

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        #endregion
    }
}
