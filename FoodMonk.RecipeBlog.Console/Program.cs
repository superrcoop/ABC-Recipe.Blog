
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMonk.RecipeBlog.Console.Data.Model;

namespace FoodMonk.RecipeBlog.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RecipeDbContext())
            {
                // Create and save a new Blog 
                System.Console.WriteLine("Welcome to Food Monk cmd Solution for a RecipeBlog ");
                System.Console.WriteLine("Enter a new Recipe.. ");
                System.Console.WriteLine("Recipe Name: ");
                var name = System.Console.ReadLine();
                System.Console.WriteLine("Recipe Type: ");

                var type = System.Console.ReadLine();
                System.Console.WriteLine("Recipe Ingredients (csv): ");
                var ningredients = System.Console.ReadLine();
                System.Console.WriteLine("Recipe Description: ");
                var description = System.Console.ReadLine();
                Random rnd = new Random();
                var Recipe = new Recipe
                {
                    Id = rnd.Next(10, 100),
                    Title = name,
                    RecipeType = type,
                    Ratings = 0,
                    Description = description,
                    CreatedOn = DateTime.UtcNow.Date
                };

                db.Recipe.Add(Recipe);
                db.SaveChanges();
             
                //Display all Entries from the database 
                var query = from b in db.Recipe
                           orderby b.RecipeType
                           select b;

                System.Console.WriteLine("All Entries in the database:");
                foreach (var item in query)
                {
                    System.Console.WriteLine(item.Title);
                }

                System.Console.WriteLine("Press any key to exit...");
                System.Console.ReadKey();
            }
        }
    }
}
