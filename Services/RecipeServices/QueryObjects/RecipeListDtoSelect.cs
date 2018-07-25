using System.Linq;
using Aplikacja_kulinarna.Models;

namespace Aplikacja_kulinarna.Services.RecipeServices.QueryObjects
{
    // Based on https://github.com/JonPSmith/EfCoreInAction

   public static class RecipeListDtoFilter
   {
        public static IQueryable<RecipeListDto> //#A
        
        MapRecipeToDto(this IQueryable<Recipe> recipes) //#A
        {
            return recipes.Select(r => new RecipeListDto()
             
               {
                RecipeId = r.RecipeId, //#B
                Dish= r.Dish, //#B
                DishRecipe = r.DishRecipe, //#B
                MinutesToPrepare = r.MinutesToPrepare, //#B
                QualityStars = r.QualityStars,//#B
               });
        }

        /*********************************************************
        #A This extension method takes in IQueryable<Recipe> and returns IQueryable<RecipeListDto>
        #B These are simple copies of existing columns in the Recipe table
        * *******************************************************/
    }

        
        
}


