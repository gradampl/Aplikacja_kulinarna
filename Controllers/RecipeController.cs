using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Aplikacja_kulinarna.Data;
using Aplikacja_kulinarna.Services.RecipeServices;
using Aplikacja_kulinarna.Services.RecipeServices.Concrete;

namespace Aplikacja_kulinarna.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private readonly CulinaryContext _context;


        public RecipeController(CulinaryContext context)

        {
             _context = context;
        }


        [HttpGet]
        public IQueryable<RecipeListDto> GetAll()
        {
            var service = new ListRecipeService(_context);
            return service.SelectAll();
        }
               
    }
}
