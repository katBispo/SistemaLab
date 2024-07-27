using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Residuos_residuoid",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_residuoid",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "residuoid",
                table: "Residuos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "residuoid",
                table: "Residuos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_residuoid",
                table: "Residuos",
                column: "residuoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Residuos_residuoid",
                table: "Residuos",
                column: "residuoid",
                principalTable: "Residuos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
