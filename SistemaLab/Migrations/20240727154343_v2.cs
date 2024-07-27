using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriaResiduoidCategoria",
                table: "Residuos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_categoriaResiduoidCategoria",
                table: "Residuos",
                column: "categoriaResiduoidCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_CategoriaResiduos_categoriaResiduoidCategoria",
                table: "Residuos",
                column: "categoriaResiduoidCategoria",
                principalTable: "CategoriaResiduos",
                principalColumn: "idCategoria",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_CategoriaResiduos_categoriaResiduoidCategoria",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_categoriaResiduoidCategoria",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "categoriaResiduoidCategoria",
                table: "Residuos");
        }
    }
}
