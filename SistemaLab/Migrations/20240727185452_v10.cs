using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_categoriaReagenteid",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_Usuarios_UsuarioId",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_CategoriaResiduos_categoriaResiduoidCategoria",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_categoriaResiduoidCategoria",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "categoriaResiduoidCategoria",
                table: "Residuos");

            migrationBuilder.RenameColumn(
                name: "categoriaReagenteid",
                table: "Reagentes",
                newName: "id_categoria");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Reagentes",
                newName: "id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_UsuarioId",
                table: "Reagentes",
                newName: "IX_Reagentes_id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_categoriaReagenteid",
                table: "Reagentes",
                newName: "IX_Reagentes_id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_id_categoria",
                table: "Residuos",
                column: "id_categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_id_categoria",
                table: "Reagentes",
                column: "id_categoria",
                principalTable: "CategoriaReagentes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagentes_Usuarios_id_usuario",
                table: "Reagentes",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_CategoriaResiduos_id_categoria",
                table: "Residuos",
                column: "id_categoria",
                principalTable: "CategoriaResiduos",
                principalColumn: "idCategoria",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_id_categoria",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_Usuarios_id_usuario",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_CategoriaResiduos_id_categoria",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_id_categoria",
                table: "Residuos");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "Reagentes",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "Reagentes",
                newName: "categoriaReagenteid");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_id_usuario",
                table: "Reagentes",
                newName: "IX_Reagentes_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_id_categoria",
                table: "Reagentes",
                newName: "IX_Reagentes_categoriaReagenteid");

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
                name: "FK_Reagentes_CategoriaReagentes_categoriaReagenteid",
                table: "Reagentes",
                column: "categoriaReagenteid",
                principalTable: "CategoriaReagentes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagentes_Usuarios_UsuarioId",
                table: "Reagentes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_CategoriaResiduos_categoriaResiduoidCategoria",
                table: "Residuos",
                column: "categoriaResiduoidCategoria",
                principalTable: "CategoriaResiduos",
                principalColumn: "idCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
