using Microsoft.EntityFrameworkCore.Migrations;

namespace Embaixadas.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Embaixadas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Embaixadas_PaisId",
                table: "Embaixadas",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Embaixadas_Pais_PaisId",
                table: "Embaixadas",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "PaisId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Embaixadas_Pais_PaisId",
                table: "Embaixadas");

            migrationBuilder.DropIndex(
                name: "IX_Embaixadas_PaisId",
                table: "Embaixadas");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Embaixadas");
        }
    }
}
