using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Devs2Blu.APIFilmes.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Pikachu vira um detetive nessa empolgante aventura Pokemon", 12, "Pokemon: Detetive Pikachu" },
                    { 2, "Acompanhe Miles Morales no multiverso com varios Spider-Mans", 12, "Spider-Man: Into The SpiderVerse" },
                    { 3, "Acompanhe os Avengers nessa emboscada contra Thanos, que esta na busca das joias do infinito", 14, "Avengers: Infinity War" },
                    { 4, "O que os animais de estimação fazem quando não estamos presentes? Descubra em PETS", 0, "Pets" },
                    { 5, "Acompanhe carros em alta velocidade e manobras nesta obra baseada no videogame", 14, "Need For Speed" },
                    { 6, "Corridas com drift te esperam na iluminada Tokyo", 16, "Fast and Furious: Tokyo Drift" },
                    { 7, "Embarque na nave Milano e acompanhe um comico grupo de herois", 10, "Guardians Of The Galaxy" },
                    { 8, "Veja o antiheroi Deadpool em uma comédia triste e cheia de ação", 18, "Deadpool 2" },
                    { 9, "Um grupo de vilões condenados luta para salvar o mundo", 16, "Suicide Squad" },
                    { 10, "Veja a triste origem do Coringa, famoso vilão da DC Comics", 18, "Joker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
