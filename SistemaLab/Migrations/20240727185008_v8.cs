using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaEquipamentos_Alunos_AlunoId",
                table: "ReservaEquipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservaEquipamentos_Equipamentos_EquipamentoId",
                table: "ReservaEquipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioId",
                table: "Residuos");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Residuos",
                newName: "id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Residuos_UsuarioId",
                table: "Residuos",
                newName: "IX_Residuos_id_usuario");

            migrationBuilder.RenameColumn(
                name: "EquipamentoId",
                table: "ReservaEquipamentos",
                newName: "id_equipamento");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "ReservaEquipamentos",
                newName: "id_aluno");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaEquipamentos_EquipamentoId",
                table: "ReservaEquipamentos",
                newName: "IX_ReservaEquipamentos_id_equipamento");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaEquipamentos_AlunoId",
                table: "ReservaEquipamentos",
                newName: "IX_ReservaEquipamentos_id_aluno");

            migrationBuilder.AlterColumn<int>(
                name: "id_usuario",
                table: "Residuos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_categoria",
                table: "Residuos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaEquipamentos_Alunos_id_aluno",
                table: "ReservaEquipamentos",
                column: "id_aluno",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaEquipamentos_Equipamentos_id_equipamento",
                table: "ReservaEquipamentos",
                column: "id_equipamento",
                principalTable: "Equipamentos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Usuarios_id_usuario",
                table: "Residuos",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaEquipamentos_Alunos_id_aluno",
                table: "ReservaEquipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservaEquipamentos_Equipamentos_id_equipamento",
                table: "ReservaEquipamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Residuos_Usuarios_id_usuario",
                table: "Residuos");

            migrationBuilder.DropColumn(
                name: "id_categoria",
                table: "Residuos");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "Residuos",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Residuos_id_usuario",
                table: "Residuos",
                newName: "IX_Residuos_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "id_equipamento",
                table: "ReservaEquipamentos",
                newName: "EquipamentoId");

            migrationBuilder.RenameColumn(
                name: "id_aluno",
                table: "ReservaEquipamentos",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaEquipamentos_id_equipamento",
                table: "ReservaEquipamentos",
                newName: "IX_ReservaEquipamentos_EquipamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaEquipamentos_id_aluno",
                table: "ReservaEquipamentos",
                newName: "IX_ReservaEquipamentos_AlunoId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Residuos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaEquipamentos_Alunos_AlunoId",
                table: "ReservaEquipamentos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaEquipamentos_Equipamentos_EquipamentoId",
                table: "ReservaEquipamentos",
                column: "EquipamentoId",
                principalTable: "Equipamentos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residuos_Usuarios_UsuarioId",
                table: "Residuos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
