using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aplikacja_kulinarna.Data;
using Aplikacja_kulinarna.Services.RecipeServices.QueryObjects;

namespace Aplikacja_kulinarna.Services.RecipeServices.Concrete
{
    // Based on https://github.com/JonPSmith/EfCoreInAction
   public class ListRecipeService
   {
        private readonly CulinaryContext _context;
        
        public ListRecipeService(CulinaryContext context)
        {
            _context = context;
        }
        
        public IQueryable<RecipeListDto> SelectAll()
        {
            var recipesQuery = _context.Recipes //#A
                .AsNoTracking() //#B
                .MapRecipeToDto(); //#C
            
            return recipesQuery.Page(0, int.MaxValue); //#D
        }
    }

}
