using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class controlePromocional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "controle_promocional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fim = table.Column<DateTime>(nullable: false),
                    Cadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_controle_promocional", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(3119), new DateTime(1973, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(58) 9113-5447" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4149), new DateTime(1967, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 4809-1196" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4178), new DateTime(1987, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(24) 3377-7530" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4187), new DateTime(1997, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(47) 6417-7556" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4195), new DateTime(1970, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(96) 9727-1594" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4203), new DateTime(1969, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(87) 5615-2404" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4210), new DateTime(1942, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 5660-1669" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4218), new DateTime(1955, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(66) 8984-4598" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4225), new DateTime(1983, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(89) 6915-3804" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4232), new DateTime(1962, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(20) 1310-6610" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4239), new DateTime(1957, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(30) 8676-5553" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4247), new DateTime(1964, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(77) 2095-4230" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4253), new DateTime(1942, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 2467-4371" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4260), new DateTime(1978, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(82) 3309-4582" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4268), new DateTime(1946, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(36) 5486-4449" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4276), new DateTime(1956, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(14) 3027-1267" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4283), new DateTime(1979, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(63) 3045-9696" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4338), new DateTime(1970, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "(63) 8499-2949" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4346), new DateTime(1960, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 5511-2451" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4354), new DateTime(1954, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "(12) 2185-3270" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4361), new DateTime(1955, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 5301-2794" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4368), new DateTime(1969, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(94) 8948-2265" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4375), new DateTime(1940, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(47) 3881-3736" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4381), new DateTime(1997, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(12) 9692-6935" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4388), new DateTime(1965, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 8399-7800" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4395), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(20) 4174-2181" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4402), new DateTime(1973, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "(31) 2013-8568" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4409), new DateTime(1940, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(84) 5556-5290" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4416), new DateTime(1971, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(93) 1773-6643" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4422), new DateTime(1969, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(78) 1966-7392" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4429), new DateTime(1987, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(50) 2279-3480" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4436), new DateTime(1955, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 8922-4174" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4443), new DateTime(1990, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(93) 1373-6087" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4450), new DateTime(1982, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(94) 2742-1125" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4457), new DateTime(1976, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(32) 6729-2348" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4463), new DateTime(1940, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(78) 5246-4000" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4471), new DateTime(1980, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "(70) 6176-6649" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4478), new DateTime(1989, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(81) 1878-4492" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4484), new DateTime(1954, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(60) 1528-5643" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(4491), new DateTime(1967, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 8677-3439" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 801, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 799, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 17, 11, 57, 800, DateTimeKind.Local).AddTicks(6019));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "controle_promocional");

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(1731), new DateTime(1970, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(40) 3749-6595" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2707), new DateTime(1970, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(92) 8187-9035" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2734), new DateTime(1946, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(24) 2627-1058" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2743), new DateTime(1948, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(31) 7017-3484" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2751), new DateTime(1950, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 6351-6584" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2758), new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(11) 4636-5296" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2766), new DateTime(1978, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 9688-8852" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2774), new DateTime(1965, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(88) 2700-5745" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2781), new DateTime(1941, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(20) 8323-3541" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2788), new DateTime(1986, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(59) 2560-2014" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2795), new DateTime(1945, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(58) 1106-2597" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2802), new DateTime(1946, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(58) 5923-6578" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2808), new DateTime(1993, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(70) 8549-2488" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2815), new DateTime(1995, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(99) 3814-2553" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2822), new DateTime(1987, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 3448-2382" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2829), new DateTime(1975, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(9) 6048-8247" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2836), new DateTime(1990, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(26) 7900-1918" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2843), new DateTime(1962, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(29) 3197-3974" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2850), new DateTime(1979, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(76) 6782-8791" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2857), new DateTime(1946, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(88) 7864-3117" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2863), new DateTime(1962, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(9) 9734-5233" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2870), new DateTime(1954, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(85) 8636-9692" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2915), new DateTime(1981, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(91) 6704-8517" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2923), new DateTime(1958, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(52) 8803-2710" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2930), new DateTime(1985, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 9102-5196" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2936), new DateTime(1998, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(32) 8383-2552" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2943), new DateTime(1957, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(45) 9931-4325" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2950), new DateTime(1964, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "(49) 1570-9326" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2956), new DateTime(1959, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "(10) 6201-2907" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2963), new DateTime(1982, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(65) 3388-2207" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2970), new DateTime(1942, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(50) 8899-9103" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2976), new DateTime(1992, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(42) 6526-3480" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2983), new DateTime(1960, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 1612-1560" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2990), new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 2769-7232" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(2997), new DateTime(1940, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(90) 5975-9343" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(3003), new DateTime(1967, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(42) 4311-3534" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(3010), new DateTime(1964, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 6307-6805" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(3016), new DateTime(1941, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(25) 7147-7161" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(3023), new DateTime(1979, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(69) 7010-9717" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(3030), new DateTime(1962, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(34) 5047-9381" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 826, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 824, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 23, 12, 825, DateTimeKind.Local).AddTicks(4409));
        }
    }
}
