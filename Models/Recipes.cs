using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenRecipesApp1.Models
{
    public class Recipe
    {
        public int RecipeID {  get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; } = 0;
        public string Unit {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Privacy { get; set; }
        public ICollection<UserRecipe> UsersRecipes { get; set; }
        public ICollection<RecipesStepsIngredientsAsoc> RecipesStepsIngredients { get; set; }

    }
}
