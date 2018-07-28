using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_kulinarna.Migrations
{
    public partial class SeedRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 1, "Chips", "Peel potatoes. Cut them into thin, long sticks. Fry them.", 10, 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 2, "Fish and chips", "Prepare chips. Fry fish. Serve together", 20, 2 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 3, "Ham sandwich", "Slice bread. Put butter on its top. Add ham.", 7, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);
        }
    }
}
