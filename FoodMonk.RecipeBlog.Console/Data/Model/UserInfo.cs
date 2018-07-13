using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodMonk.RecipeBlog.Console.Data.Model
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
