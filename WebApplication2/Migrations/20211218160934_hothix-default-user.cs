using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class hothixdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e3e0d82-9699-49d5-b9c9-5a63a9e8020b", "AQAAAAEAACcQAAAAEFVi4kFLydD4hNjrJJivUWzyIN6u60OJbDJY61A0KYgzdbJAoSg4TnQvFbey5zMmWw==", "52805fe7-5bbe-46b5-b6c4-2ba7f9718f99", "g191210018@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d1a5df0b-8f6f-4358-9d0e-ae99fd8bc89b", "AQAAAAEAACcQAAAAECbhdGsCspYIeyqbuqSc1ZAjLZhOV6WjvU3qEGyYuux+2oXBSJZSgCRv8PHkAgypxQ==", "277ebab2-2984-4569-8c8d-381fb7b186e0", "g191210057@sakarya.edu.tr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "53d0dc61-70e0-4e89-b78e-745cdbe5acbf", "AQAAAAEAACcQAAAAEM0BbA6hNlt61cIHXcDurCrk7p6uxTUjDj+W8S/ioB22V61B4DD12e4x9GzluyCNTw==", "31cdcb56-0f0f-4aca-9387-feabbe77b8f6", "g191210018@sakarya.edur.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0e91406f-8753-4f61-a1d7-87b4dc704c09", "AQAAAAEAACcQAAAAEEC5YqnICCFSRJ0WRrulgyrDdSGIEmMBsajJFTvgXKOituwoFy48Za9+3yeyS8O/NQ==", "941ea16d-474e-450f-bb98-4db39db5fb51", "g191210057@sakarya.edur.tr" });
        }
    }
}
