using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacja_kulinarna.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplikacja_kulinarna.Data

{
    public class CulinaryContext:DbContext
    {
        public CulinaryContext(DbContextOptions<CulinaryContext> options) 
           : base(options) 
           {
           
           }

        public DbSet<Recipe>Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Recipe>()
                .ToTable("Recipes")
                .Property(r => r.DishRecipe)
                .HasMaxLength(2000);           


            modelBuilder.Entity<Recipe>()
             .HasData(
                 new Recipe()
                    {   RecipeId = 1,
                        Dish = "Chips",
                        DishRecipe = "Peel potatoes. Cut them into thin, long sticks. Fry them.",
                        MinutesToPrepare = 10,
                        QualityStars = 1,
                    },


                 new Recipe()
                    {
                        RecipeId = 2,
                        Dish = "Fish and chips",
                        DishRecipe = "Prepare chips. Fry fish. Serve together",
                        MinutesToPrepare = 20,
                        QualityStars = 2,
                    },

                 new Recipe()
                    {
                        RecipeId = 3,
                        Dish = "Ham sandwich",
                        DishRecipe = "Slice bread. Put butter on its top. Add ham.",
                        MinutesToPrepare = 7,
                        QualityStars = 3,
                    }
                 );

          }
     }
}
