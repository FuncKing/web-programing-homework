using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class saledatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "dateTime",
                table: "sales",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b32b54-5c6f-455b-9390-3eb841f7b617", "AQAAAAEAACcQAAAAEORgHxTOcGQf3hyANZHeDyj95fI3kE0M1t5ZWtx+TYXe9wMs/nEGm8nZMRx6CaFlcw==", "7d10b5cc-7d52-46f9-b618-81fc79874b52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca40d416-f078-42dc-a049-fa235c81a8c3", "AQAAAAEAACcQAAAAEIv2xmy3umZ/kGXbXGk4WAGA3aQfnsrP0rczUCoyr4HvAzrn1WvUP/XcQmw7ro6tdw==", "fafce5ef-6493-4250-bb9d-9b5627da7443" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "sales");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "067a7273-2f2d-48c6-b383-df00a3c9faf1", "AQAAAAEAACcQAAAAEIYNYFQgapCYCmdfzLU/hB9DGUjJFcs8Ds4mAdxWYToRdACAdBQli4Bmp6zT5jYkNQ==", "c551842c-d76b-44f3-a67e-56904b48c6f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b74e9ed3-1184-4fdc-881c-89a6dfcbb124", "AQAAAAEAACcQAAAAENXeqKlrQ3YSmzXi2MwiPUw2EuHnLpXp/R5/nzDMAEOOS2uGmUQyLpJGbqnrPurXuQ==", "7bc064b3-ff28-4f17-aa66-255b4fa09959" });
        }
    }
}
