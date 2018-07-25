﻿// <auto-generated />
using Aplikacja_kulinarna.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aplikacja_kulinarna.Migrations
{
    [DbContext(typeof(CulinaryContext))]
    partial class CulinaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Aplikacja_kulinarna.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dish");

                    b.Property<string>("DishRecipe");

                    b.Property<int>("MinutesToPrepare");

                    b.Property<int>("QualityStars");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
