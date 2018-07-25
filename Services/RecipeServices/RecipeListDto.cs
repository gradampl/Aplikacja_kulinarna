using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aplikacja_kulinarna.Data;
using Aplikacja_kulinarna.Services.RecipeServices.QueryObjects;

namespace Aplikacja_kulinarna.Services.RecipeServices

{
    
   public class RecipeListDto
   {
        public int RecipeId { get; set; }
        public string Dish { get; set; }
        public string DishRecipe { get; set; }
        public int MinutesToPrepare { get; set; }
        public int QualityStars { get; set; } 
        
        //TODO add remaining data (e.g. collection of Ingredients)   

   }

}
