using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Migrations
{
    /// <inheritdoc />
    public partial class InicialTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "jogos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nota = table.Column<double>(type: "float", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogos", x => x.id);
                    table.ForeignKey(
                        name: "FK_jogos_generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "generos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Ação/Aventura" },
                    { 2, "Corrida" },
                    { 3, "Esporte" },
                    { 4, "FPS" },
                    { 5, "RPG" },
                    { 6, "Plataforma" },
                    { 7, "Terror" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_jogos_GeneroId",
                table: "jogos",
                column: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jogos");

            migrationBuilder.DropTable(
                name: "generos");
        }
    }
}
