using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class productimagepathadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "weight",
                table: "products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imagePath",
                table: "products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d0dc61-70e0-4e89-b78e-745cdbe5acbf", "AQAAAAEAACcQAAAAEM0BbA6hNlt61cIHXcDurCrk7p6uxTUjDj+W8S/ioB22V61B4DD12e4x9GzluyCNTw==", "31cdcb56-0f0f-4aca-9387-feabbe77b8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e91406f-8753-4f61-a1d7-87b4dc704c09", "AQAAAAEAACcQAAAAEEC5YqnICCFSRJ0WRrulgyrDdSGIEmMBsajJFTvgXKOituwoFy48Za9+3yeyS8O/NQ==", "941ea16d-474e-450f-bb98-4db39db5fb51" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagePath",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "weight",
                table: "products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388d7f7b-de87-4d6e-bbb6-dea0a805e266", "AQAAAAEAACcQAAAAECcWhz5LKooXVU/2L1yiClEu6feE3JDpJyJcbdeWYyVmngTl5gPScY3Q70Ooj584hQ==", "902c9fc9-fd88-497f-bfea-431999843e1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "444c4925-6780-440c-bee1-11f5d4e7317b", "AQAAAAEAACcQAAAAEAhnjA+fjq9U7uDfBTNUTR2BEvaQLlxce13XLY3strgK0qnA0NmW9K3f6eRdjxdLjQ==", "ff216415-8b8f-489d-bdb0-c1a60f382a9e" });
        }
    }
}
