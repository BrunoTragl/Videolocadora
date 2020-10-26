using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class nullDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Multa",
                table: "aluguel",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Devolveu",
                table: "aluguel",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(277), new DateTime(1959, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(31) 7011-2009" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1322), new DateTime(1977, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(83) 8897-6044" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1350), new DateTime(1973, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(87) 9909-7301" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1359), new DateTime(1976, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(28) 1721-4240" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1369), new DateTime(1967, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(46) 5653-6061" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1432), new DateTime(1996, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(97) 1417-4051" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1441), new DateTime(1973, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(17) 5319-5715" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1449), new DateTime(1963, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 9287-9090" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1457), new DateTime(1971, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(98) 1573-7028" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1465), new DateTime(1982, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(13) 8155-2068" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1472), new DateTime(1974, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(85) 9089-8244" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1480), new DateTime(1943, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 3887-6251" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1487), new DateTime(1946, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(29) 8434-3042" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1495), new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 9100-1369" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1502), new DateTime(1940, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(84) 3518-9426" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1510), new DateTime(1953, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(52) 5829-3529" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1517), new DateTime(1962, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(76) 6303-4153" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1525), new DateTime(1989, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(97) 8925-6042" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1532), new DateTime(1947, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(90) 3125-9966" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1540), new DateTime(1969, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(18) 8575-9626" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1547), new DateTime(1988, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 5380-8402" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1554), new DateTime(1999, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(33) 8671-3599" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1562), new DateTime(1956, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(34) 8580-1863" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1569), new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(49) 7398-8291" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1590), new DateTime(1979, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(64) 9882-6677" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1598), new DateTime(1999, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(99) 9549-4253" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1605), new DateTime(1943, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 1024-3288" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1613), new DateTime(1976, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(99) 6578-2563" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1656), new DateTime(1988, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(27) 3001-8317" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1664), new DateTime(1994, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(52) 5490-2440" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1671), new DateTime(1974, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(39) 3572-6277" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1679), new DateTime(1976, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(86) 2960-2642" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1687), new DateTime(1987, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(82) 8692-8729" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1694), new DateTime(1951, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(17) 8450-7968" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1703), new DateTime(1974, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(89) 1869-6420" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1710), new DateTime(1991, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 7945-6808" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1718), new DateTime(1977, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(11) 4611-4084" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1725), new DateTime(1943, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(89) 4812-7020" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1734), new DateTime(1988, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 3585-8574" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(1741), new DateTime(1967, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(87) 7913-5555" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 938, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 936, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 3, 8, 9, 937, DateTimeKind.Local).AddTicks(2899));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Multa",
                table: "aluguel",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Devolveu",
                table: "aluguel",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(7647), new DateTime(1952, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(31) 4777-6862" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8612), new DateTime(1950, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(55) 5493-6481" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8639), new DateTime(1958, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 1277-4968" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8648), new DateTime(1955, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(76) 2627-5989" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8656), new DateTime(1945, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(85) 5461-2849" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8663), new DateTime(1947, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(13) 9666-4951" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8670), new DateTime(1971, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 6053-9941" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8677), new DateTime(1970, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(86) 1426-6501" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8684), new DateTime(1969, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(81) 9023-1160" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8691), new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(38) 2374-1346" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8698), new DateTime(1971, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(59) 4561-4081" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8705), new DateTime(1993, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(38) 6674-2511" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8712), new DateTime(1953, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(41) 3276-6170" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8719), new DateTime(1979, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(57) 4235-3653" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8726), new DateTime(1996, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(74) 2494-5539" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8732), new DateTime(1983, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "(25) 2787-3156" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8739), new DateTime(2000, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(59) 9805-8225" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8816), new DateTime(1990, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(18) 6205-4062" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8824), new DateTime(1964, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 7087-9208" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8831), new DateTime(1982, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 6598-1664" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8838), new DateTime(1944, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(34) 6513-5019" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8845), new DateTime(1967, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(43) 4338-3821" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8851), new DateTime(1962, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(57) 7320-2833" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8858), new DateTime(1984, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "(93) 3897-6775" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8865), new DateTime(1958, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(81) 5304-2940" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8872), new DateTime(1956, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(21) 5340-8418" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8878), new DateTime(1984, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(20) 6841-5882" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8885), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(90) 8057-6255" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8892), new DateTime(1979, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(78) 9849-8188" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8898), new DateTime(1960, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(48) 9834-1405" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8905), new DateTime(1997, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(21) 1937-1795" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8912), new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(48) 8254-2412" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8919), new DateTime(1980, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(27) 9432-3765" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8925), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(93) 2329-3737" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8932), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 8251-3968" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8938), new DateTime(2000, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(54) 2656-9901" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8945), new DateTime(2000, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(14) 9058-6006" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8953), new DateTime(1999, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "(20) 1879-4439" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8959), new DateTime(1978, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 9530-6169" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(8966), new DateTime(1955, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(32) 2815-6265" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 453, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 450, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 2, 28, 24, 452, DateTimeKind.Local).AddTicks(647));
        }
    }
}
