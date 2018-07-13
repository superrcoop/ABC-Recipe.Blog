using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodMonk.RecipeBlog.Console.Data.Model
{
    public class RecipeDbContext : DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Recipe> Recipe { get; set; }


    }
}
