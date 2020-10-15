using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(1000)", nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Sobrenome = table.Column<string>(type: "VARCHAR(300)", nullable: false),
                    Login = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aluguel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorPago = table.Column<decimal>(nullable: false),
                    Multa = table.Column<decimal>(nullable: false),
                    Devolucao = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false),
                    FilmeId = table.Column<int>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aluguel_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aluguel_filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aluguel_funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_ClienteId",
                table: "aluguel",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_FilmeId",
                table: "aluguel",
                column: "FilmeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aluguel_FuncionarioId",
                table: "aluguel",
                column: "FuncionarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aluguel");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "filme");

            migrationBuilder.DropTable(
                name: "funcionario");
        }
    }
}
