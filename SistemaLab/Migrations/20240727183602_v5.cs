using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_CategoriaReagenteid",
                table: "Reagentes");

            migrationBuilder.RenameColumn(
                name: "CategoriaReagenteid",
                table: "Reagentes",
                newName: "categoriaReagenteid");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_CategoriaReagenteid",
                table: "Reagentes",
                newName: "IX_Reagentes_categoriaReagenteid");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Residuos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "residuoid",
                table: "Residuos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "categoriaReagenteid",
                table: "Reagentes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Reagentes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_residuoid",
                table: "Residuos",
                column: "residuoid");

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_UsuarioId",
                table: "Residuos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reagentes_UsuarioId",
                table: "Reagentes",
                column: "UsuarioId");

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
                name: "FK_Residuos_Residuos_residuoid",
                table: "Residuos",
                column: "residuoid",
                principalTable: "Residuos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioId",
                table: "Residuos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_categoriaReagenteid",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagentes_Usuarios_UsuarioId",
                table: "Reagentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Residuos_residuoid",
                table: "Residuos");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioId",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_residuoid",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Residuos_UsuarioId",
                table: "Residuos");

            migrationBuilder.DropIndex(
                name: "IX_Reagentes_UsuarioId",
                table: "Reagentes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "residuoid",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Reagentes");

            migrationBuilder.RenameColumn(
                name: "categoriaReagenteid",
                table: "Reagentes",
                newName: "CategoriaReagenteid");

            migrationBuilder.RenameIndex(
                name: "IX_Reagentes_categoriaReagenteid",
                table: "Reagentes",
                newName: "IX_Reagentes_CategoriaReagenteid");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaReagenteid",
                table: "Reagentes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagentes_CategoriaReagentes_CategoriaReagenteid",
                table: "Reagentes",
                column: "CategoriaReagenteid",
                principalTable: "CategoriaReagentes",
                principalColumn: "id");
        }
    }
}
