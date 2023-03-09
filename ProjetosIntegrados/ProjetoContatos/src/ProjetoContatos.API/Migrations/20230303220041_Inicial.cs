using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetoContatos.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "Bairro", "Cidade", "Estado", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Vila Itoupava", "Blumenau", "SC", "Tuca", "(47) 99457-8964" },
                    { 2, "Vila Itoupava", "Blumenau", "SC", "Mel", "(47) 99657-8212" },
                    { 3, "Vila Itoupava", "Blumenau", "SC", "Zuky", "(47) 99123-8785" },
                    { 4, "Vila Itoupava", "Blumenau", "SC", "Bidu", "(47) 99932-7452" },
                    { 5, "Vila Itoupava", "Blumenau", "SC", "Lilica", "(47) 99445-6787" },
                    { 6, "Vila Itoupava", "Blumenau", "SC", "Nickolas", "(47) 99985-8554" },
                    { 7, "Vila Itoupava", "Blumenau", "SC", "Nanica", "(47) 99457-8545" },
                    { 8, "Vila Itoupava", "Blumenau", "SC", "Peta", "(47) 99145-1225" },
                    { 9, "Vila Itoupava", "Blumenau", "SC", "Mingui", "(47) 99487-5412" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
