using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "a2eaac30-f7a2-41fc-846d-ad42750aa21b", "Aseo Hogar" },
                    { "ba92efc6-a6a1-4796-b62b-2563aff174f8", "Aseo" },
                    { "69e53ac3-bded-4287-ba7d-ffefcd44e4ea", "Hogar" },
                    { "e21f22b7-4e53-46c4-8970-e718542f2aad", "Perfumeria" },
                    { "e13cbdaf-26b6-4a84-adbe-cd866044ab1f", "Salud" },
                    { "f0041614-eebd-457d-8121-97d10ec2d41c", "Videojuegos" }
                });

            migrationBuilder.InsertData(
                table: "Wherehouses",
                columns: new[] { "WherehouseId", "WherehouseAddress", "WherehouseName" },
                values: new object[,]
                {
                    { "9e7c2f15-f7df-4d85-96e6-9e147b5cb295", "Calle 123", "Bodega central" },
                    { "d10e8482-8ba1-40c4-9c8a-13c31b9e5774", "Calle 562", "Bodega Sur" },
                    { "78d542be-670f-433d-98cc-cf73d68f52ec", "Calle 987", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "69e53ac3-bded-4287-ba7d-ffefcd44e4ea");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a2eaac30-f7a2-41fc-846d-ad42750aa21b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ba92efc6-a6a1-4796-b62b-2563aff174f8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "e13cbdaf-26b6-4a84-adbe-cd866044ab1f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "e21f22b7-4e53-46c4-8970-e718542f2aad");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "f0041614-eebd-457d-8121-97d10ec2d41c");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehouseId",
                keyValue: "78d542be-670f-433d-98cc-cf73d68f52ec");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehouseId",
                keyValue: "9e7c2f15-f7df-4d85-96e6-9e147b5cb295");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehouseId",
                keyValue: "d10e8482-8ba1-40c4-9c8a-13c31b9e5774");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
