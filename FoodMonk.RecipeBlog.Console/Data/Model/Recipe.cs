using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodMonk.RecipeBlog.Console.Data.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Ratings { get; set; }
        public DateTime CreatedOn { get; set; }
        public string RecipeType { get; set; }

        public int UserId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
