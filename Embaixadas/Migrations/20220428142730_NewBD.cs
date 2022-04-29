using Microsoft.EntityFrameworkCore.Migrations;

namespace Embaixadas.Migrations
{
    public partial class NewBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Embaixadas",
                columns: table => new
                {
                    EmbaixadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmbaixadaNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmbaixadaEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmbaixadaNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmbaixadaEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embaixadas", x => x.EmbaixadaId);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    PaisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisCapital = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.PaisId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embaixadas");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
