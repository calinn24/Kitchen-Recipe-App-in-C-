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
    [PrimaryKey(nameof(RecipeID), nameof(IngredientID), nameof(StepID))]
    public class RecipesStepsIngredientsAsoc
        {
            
            public int RecipeID { get; set; }

            public Recipe Recipe { get; set; }
            public int StepID { get; set; }

            public Step Step { get; set; }
            public int IngredientID { get; set; }
            public Ingredient Ingredient { get; set; }
            public int OrderNB { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        }
    
}
