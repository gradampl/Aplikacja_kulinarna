﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplikacja_kulinarna.Migrations
{
    public partial class RecipeDraftModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dish = table.Column<string>(nullable: true),
                    DishRecipe = table.Column<string>(nullable: true),
                    MinutesToPrepare = table.Column<int>(nullable: false),
                    QualityStars = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
