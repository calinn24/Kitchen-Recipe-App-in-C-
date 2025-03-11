﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenRecipesApp1.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public ICollection<UserRecipe> UsersRecipes { get; set; }

    }

}
