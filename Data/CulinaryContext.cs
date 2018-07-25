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
        public DbSet<Recipe>Recipes { get; set; }
        public CulinaryContext(DbContextOptions<CulinaryContext> options) : base(options) { }

        
    }
}
