using Microsoft.EntityFrameworkCore.Migrations;

namespace Embaixadas.Migrations
{
    public partial class AddMoedas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaisMoeda",
                table: "Pais",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaisMoeda",
                table: "Pais");
        }
    }
}
