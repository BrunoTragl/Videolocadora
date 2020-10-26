using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class RemoveNullDefaultValues : Migration
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
    }
}
