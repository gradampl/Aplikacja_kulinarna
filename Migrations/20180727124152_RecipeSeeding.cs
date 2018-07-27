using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_kulinarna.Migrations
{
    public partial class RecipeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "DishRecipe",
                value: "Peel potatoes. Cut them into thin, long sticks. Fry them.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "DishRecipe",
                value: "Peel potatoes. Chop them into thin, long sticks. Fry them.");
        }
    }
}
