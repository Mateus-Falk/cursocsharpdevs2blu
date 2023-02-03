using Devs2Blu.APIFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>()
                .HasData(
                new {Id = 1, Title = "Pokemon: Detetive Pikachu", Description = "Pikachu vira um detetive nessa empolgante aventura Pokemon", Rating = 12 },
                new {Id = 2, Title = "Spider-Man: Into The SpiderVerse", Description = "Acompanhe Miles Morales no multiverso com varios Spider-Mans", Rating = 12 },
                new {Id = 3, Title = "Avengers: Infinity War", Description = "Acompanhe os Avengers nessa emboscada contra Thanos, que esta na busca das joias do infinito", Rating = 14 },
                new {Id = 4, Title = "Pets", Description = "O que os animais de estimação fazem quando não estamos presentes? Descubra em PETS", Rating = 0 },
                new {Id = 5, Title = "Need For Speed", Description = "Acompanhe carros em alta velocidade e manobras nesta obra baseada no videogame", Rating = 14 },
                new {Id = 6, Title = "Fast and Furious: Tokyo Drift", Description = "Corridas com drift te esperam na iluminada Tokyo", Rating = 16 },
                new {Id = 7, Title = "Guardians Of The Galaxy", Description = "Embarque na nave Milano e acompanhe um comico grupo de herois", Rating = 10 },
                new {Id = 8, Title = "Deadpool 2", Description = "Veja o antiheroi Deadpool em uma comédia triste e cheia de ação", Rating = 18 },
                new {Id = 9, Title = "Suicide Squad", Description = "Um grupo de vilões condenados luta para salvar o mundo", Rating = 16 },
                new { Id = 10, Title = "Joker", Description = "Veja a triste origem do Coringa, famoso vilão da DC Comics", Rating = 18 }
                );
        }

        #region DbSets<Tables>
        public DbSet<Movies> movies { get; set; }
        #endregion
    }
}
