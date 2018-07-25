using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_kulinarna.Migrations
{
    public partial class SeedRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "RecipeId");

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 1, "Tea", "Boil water and add tea", 3, 1 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 2, "Coffe", "Boil water. Add coffe and sugar", 5, 2 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Dish", "DishRecipe", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 3, "Caffe Latte", "Boil water. Add coffe. Add milk. Add sugar", 7, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "RecipeId");
        }
    }
}
