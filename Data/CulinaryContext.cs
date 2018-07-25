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
             .ToTable("Recipe")
             .Property(r => r.DishRecipe)
             .HasMaxLength(2000);

          modelBuilder.Entity<Recipe>()
             .HasData(
                 new Recipe()
                    {   RecipeId = 1,
                        Dish = "Tea",
                        DishRecipe = "Boil water and add tea",
                        MinutesToPrepare = 3,
                        QualityStars = 1,
                    },


                 new Recipe()
                    {
                        RecipeId = 2,
                        Dish = "Coffe",
                        DishRecipe = "Boil water. Add coffe and sugar",
                        MinutesToPrepare = 5,
                        QualityStars = 2,
                    },

                 new Recipe()
                    {
                        RecipeId = 3,
                        Dish = "Caffe Latte",
                        DishRecipe = "Boil water. Add coffe. Add milk. Add sugar",
                        MinutesToPrepare = 7,
                        QualityStars = 3,
                    }
                 );

          }
     }
}
