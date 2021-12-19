using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class productdescaddandsalepricedelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productSeries_products_ProductId",
                table: "productSeries");

            migrationBuilder.DropForeignKey(
                name: "FK_productSeries_sellers_SellerId",
                table: "productSeries");

            migrationBuilder.DropColumn(
                name: "price",
                table: "sales");

            migrationBuilder.RenameColumn(
                name: "quntity",
                table: "sales",
                newName: "quantity");

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "productSeries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "products",
                type: "text",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_productSeries_products_ProductId",
                table: "productSeries",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "barcode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_productSeries_sellers_SellerId",
                table: "productSeries",
                column: "SellerId",
                principalTable: "sellers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productSeries_products_ProductId",
                table: "productSeries");

            migrationBuilder.DropForeignKey(
                name: "FK_productSeries_sellers_SellerId",
                table: "productSeries");

            migrationBuilder.DropColumn(
                name: "description",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "sales",
                newName: "quntity");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "sales",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SellerId",
                table: "productSeries",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2be08b40-df64-45c5-8c57-9a75177dd288", "AQAAAAEAACcQAAAAENDassJo/1Jrcz3MQL8qlTb88C7LJhRlBTY+xduqqLYJ71VwpH4U1cn7clNglcEwUA==", "9d93052d-3422-4ac2-a27f-c44b7091dce3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03a6ce24-d347-42d7-b749-d4be07965b00", "AQAAAAEAACcQAAAAEMN+9GpdH1o4CZNz4DsLE1deK2843EvAURd4rCMjpS1Wzy/tEIDYjraJexZ03dzY9A==", "5e59a408-7747-4af9-ae05-ab4132bd3bf4" });

            migrationBuilder.AddForeignKey(
                name: "FK_productSeries_products_ProductId",
                table: "productSeries",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "barcode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSeries_sellers_SellerId",
                table: "productSeries",
                column: "SellerId",
                principalTable: "sellers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
