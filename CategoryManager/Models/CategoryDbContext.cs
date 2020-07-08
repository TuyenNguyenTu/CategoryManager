using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryManager.Models
{
    public class CategoryDbContext :DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { set; get; }
    }
}
