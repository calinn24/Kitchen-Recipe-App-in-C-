using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KitchenRecipesApp1.Models
{
    [PrimaryKey(nameof(UserID), nameof(RecipeID))]
    public class UserRecipe
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

    }
}
