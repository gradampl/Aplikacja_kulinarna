using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aplikacja_kulinarna
{
    public class CulinaryContext:DbContext
    {
        public DbSet<Recipe>Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Culinary;Trusted_Connection=True;");
        }
    }
}
