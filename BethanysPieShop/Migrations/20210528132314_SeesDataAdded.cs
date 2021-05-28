using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class SeesDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit Pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheesse Cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal Pies", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "", "", true, true, "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth", "Apple Pie", 12.95m, "Our Famous Apple Pies" },
                    { 2, "", 2, "", "", true, true, "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth", "Blue Berry Cheesse cakes", 12.95m, "Cheesseyest Cheesse cake" },
                    { 3, "", 2, "", "", true, true, "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth", "Cheesse cakes", 12.95m, "Cheesseyest Cheesse cake" },
                    { 4, "", 3, "", "", true, true, "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth", "Winter cakes", 12.95m, "Seasons Pie" },
                    { 5, "", 3, "", "", true, true, "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth", "4 Season Pie cakes", 12.95m, "Seasons Pie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
