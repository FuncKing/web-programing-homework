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
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2be08b40-df64-45c5-8c57-9a75177dd288", "g191210018@sakarya.edu.tr", "AQAAAAEAACcQAAAAENDassJo/1Jrcz3MQL8qlTb88C7LJhRlBTY+xduqqLYJ71VwpH4U1cn7clNglcEwUA==", "9d93052d-3422-4ac2-a27f-c44b7091dce3", "g191210018@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "03a6ce24-d347-42d7-b749-d4be07965b00", "g191210057@sakarya.edu.tr", "AQAAAAEAACcQAAAAEMN+9GpdH1o4CZNz4DsLE1deK2843EvAURd4rCMjpS1Wzy/tEIDYjraJexZ03dzY9A==", "5e59a408-7747-4af9-ae05-ab4132bd3bf4", "g191210057@sakarya.edu.tr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "53d0dc61-70e0-4e89-b78e-745cdbe5acbf", "g191210018@sakarya.edur.tr", "AQAAAAEAACcQAAAAEM0BbA6hNlt61cIHXcDurCrk7p6uxTUjDj+W8S/ioB22V61B4DD12e4x9GzluyCNTw==", "31cdcb56-0f0f-4aca-9387-feabbe77b8f6", "g191210018@sakarya.edur.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0e91406f-8753-4f61-a1d7-87b4dc704c09", "g191210057@sakarya.edur.tr", "AQAAAAEAACcQAAAAEEC5YqnICCFSRJ0WRrulgyrDdSGIEmMBsajJFTvgXKOituwoFy48Za9+3yeyS8O/NQ==", "941ea16d-474e-450f-bb98-4db39db5fb51", "g191210057@sakarya.edur.tr" });
        }
    }
}
