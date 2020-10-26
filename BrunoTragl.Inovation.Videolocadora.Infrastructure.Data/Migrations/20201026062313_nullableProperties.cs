using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class nullableProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Multa",
                table: "aluguel",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Devolveu",
                table: "aluguel",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Multa",
                table: "aluguel",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Devolveu",
                table: "aluguel",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 308, DateTimeKind.Local).AddTicks(9811), new DateTime(1991, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(14) 2205-6697" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(759), new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(61) 8519-9831" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(786), new DateTime(1959, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 8326-7037" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(795), new DateTime(1987, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(83) 6853-5923" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(804), new DateTime(1980, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 8961-3404" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(811), new DateTime(1961, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(25) 5794-5461" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(819), new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(51) 8370-1753" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(826), new DateTime(1996, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(29) 9078-7611" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(833), new DateTime(1952, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(26) 9778-1173" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(840), new DateTime(1985, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(41) 4584-9623" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(903), new DateTime(1998, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(40) 2968-8890" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(911), new DateTime(1955, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(71) 3030-7908" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(918), new DateTime(1990, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(46) 8983-1112" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(925), new DateTime(2000, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(93) 5453-3131" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(932), new DateTime(1971, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 4951-5598" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(939), new DateTime(1947, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(89) 5547-8200" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(946), new DateTime(1979, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(70) 9768-7949" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(953), new DateTime(1967, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(98) 4287-6953" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(960), new DateTime(1996, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(42) 4290-9646" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(967), new DateTime(1981, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(27) 8400-1473" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(974), new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(79) 6080-6997" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(980), new DateTime(1947, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(36) 7946-3712" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(987), new DateTime(1976, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 5324-9699" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(994), new DateTime(1989, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(38) 8083-1965" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1000), new DateTime(1962, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(71) 2828-5224" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1007), new DateTime(1956, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(42) 8022-4872" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1013), new DateTime(1945, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(77) 8729-4779" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1020), new DateTime(1992, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(84) 7927-1390" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1027), new DateTime(1970, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(59) 4498-3518" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1033), new DateTime(1955, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(61) 4567-8272" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1040), new DateTime(1968, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 1190-3990" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1047), new DateTime(1972, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(11) 4777-8225" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1053), new DateTime(1940, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(43) 5216-2463" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1087), new DateTime(1973, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 2705-1257" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1094), new DateTime(1995, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(52) 2028-2873" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1100), new DateTime(1981, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 3543-4837" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1107), new DateTime(1981, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(29) 3654-5883" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1113), new DateTime(1970, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(77) 5986-3964" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1120), new DateTime(1976, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(63) 1282-8677" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(1127), new DateTime(1990, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 4823-3720" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 309, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 307, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 13, 35, 308, DateTimeKind.Local).AddTicks(2869));
        }
    }
}
