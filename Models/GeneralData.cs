using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenRecipesApp1.Models
{
    public static class GeneralData
    {
        public static User CurrentUser { get; set; }
        public static Recipe CurrentRecipe { get; set; }

        public static List<string> units = new List<string> {"g", "kg", "ml", "l", "buc", "cana", "lingura", "lingurita", "bucata", "felie", "cutie", "pachet", "gram", "litru", "picatura", "teaspoon", "tablespoon", "cup", "ounce", "pound"};


    }
}
