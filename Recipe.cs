using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_kulinarna
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Dish { get; set; }
        public string DishRecipe { get; set; }
        public int MinutesToPrepare { get; set; }
        public int QualityStars { get; set; }
    }
}
