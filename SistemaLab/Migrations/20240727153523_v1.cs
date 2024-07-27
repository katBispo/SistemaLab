using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaLab.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaReagentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeCategoria = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaReagentes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaResiduos",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoria = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaResiduos", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeEquipamento = table.Column<string>(type: "TEXT", nullable: false),
                    statusEquipamento = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Residuos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    dataGeracao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    statusResiduo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residuos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    UserType = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", nullable: true),
                    registroProfissional = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reagentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    dataVencimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    fabricante = table.Column<string>(type: "TEXT", nullable: false),
                    lote = table.Column<string>(type: "TEXT", nullable: false),
                    CategoriaReagenteid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reagentes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reagentes_CategoriaReagentes_CategoriaReagenteid",
                        column: x => x.CategoriaReagenteid,
                        principalTable: "CategoriaReagentes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ReservaEquipamentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaEquipamentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ReservaEquipamentos_Equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Equipamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaEquipamentos_Usuarios_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reagentes_CategoriaReagenteid",
                table: "Reagentes",
                column: "CategoriaReagenteid");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaEquipamentos_AlunoId",
                table: "ReservaEquipamentos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaEquipamentos_EquipamentoId",
                table: "ReservaEquipamentos",
                column: "EquipamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaResiduos");

            migrationBuilder.DropTable(
                name: "Reagentes");

            migrationBuilder.DropTable(
                name: "ReservaEquipamentos");

            migrationBuilder.DropTable(
                name: "Residuos");

            migrationBuilder.DropTable(
                name: "CategoriaReagentes");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
