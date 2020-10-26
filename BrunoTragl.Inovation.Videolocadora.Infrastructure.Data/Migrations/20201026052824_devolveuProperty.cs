using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    public partial class devolveuProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Devolveu",
                table: "aluguel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Devolveu",
                table: "aluguel");

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(4904), new DateTime(1963, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(95) 9334-5470" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5901), new DateTime(1955, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 5486-1877" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5929), new DateTime(1941, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(18) 5507-8519" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5938), new DateTime(1989, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "(80) 5906-2976" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5948), new DateTime(1975, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(99) 2100-2168" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5956), new DateTime(1970, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(91) 1487-6639" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5963), new DateTime(1967, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 9115-7838" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5971), new DateTime(1958, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(67) 8474-7207" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5978), new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(23) 4495-5673" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5985), new DateTime(1944, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(60) 4253-5479" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5991), new DateTime(1980, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(33) 6852-8567" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(5998), new DateTime(1988, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(54) 6779-2547" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6058), new DateTime(1994, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(47) 5378-5537" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6066), new DateTime(1960, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 2793-6685" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6074), new DateTime(1985, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(80) 8495-5093" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6081), new DateTime(1960, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "(48) 9908-6825" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6088), new DateTime(1983, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "(13) 8683-7441" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6095), new DateTime(1989, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(27) 3375-3006" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6102), new DateTime(1979, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(80) 3121-4783" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6109), new DateTime(1994, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "(46) 5667-3786" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6116), new DateTime(1974, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "(46) 2423-7783" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6122), new DateTime(1952, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(28) 7407-5125" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6129), new DateTime(1946, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(89) 3954-9145" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6136), new DateTime(1987, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "(13) 2172-2702" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6142), new DateTime(1960, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "(58) 5842-5304" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6149), new DateTime(1976, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "(16) 5248-8624" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6155), new DateTime(1966, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "(17) 1002-8223" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6162), new DateTime(1942, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "(68) 7014-9504" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6169), new DateTime(1960, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "(22) 6663-9737" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6176), new DateTime(1954, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "(17) 1659-6396" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6182), new DateTime(1946, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(72) 6618-4684" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6189), new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "(30) 5030-9319" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6196), new DateTime(1986, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(33) 9986-7223" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6202), new DateTime(1955, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "(73) 2920-5678" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6209), new DateTime(1958, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "(57) 8629-9517" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6255), new DateTime(1999, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "(57) 9939-4082" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6263), new DateTime(1993, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "(56) 7345-6720" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6270), new DateTime(1947, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "(32) 4424-9463" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6277), new DateTime(1965, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "(25) 8514-4467" });

            migrationBuilder.UpdateData(
                table: "cliente",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Cadastro", "Nascimento", "Telefone" },
                values: new object[] { new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(6284), new DateTime(1983, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "(45) 4614-2636" });

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 5,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 6,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 7,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 8,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 9,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 10,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 11,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 12,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 13,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 14,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 15,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 16,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 17,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 18,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 19,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 20,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 21,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 22,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 23,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 24,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 25,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 27,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 28,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 29,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 30,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 31,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 32,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 33,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 34,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 35,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 36,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 37,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 38,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 39,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "filme",
                keyColumn: "Id",
                keyValue: 40,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 302, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 300, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "funcionario",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cadastro",
                value: new DateTime(2020, 10, 26, 1, 39, 15, 301, DateTimeKind.Local).AddTicks(7933));
        }
    }
}
