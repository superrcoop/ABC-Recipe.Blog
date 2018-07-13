using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodMonk.RecipeBlog.Console.Data.Model
{
    public class UserProfile
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Diet { get; set; }
        public virtual List<Recipe> Recipes { get; set; } 
    }
}
