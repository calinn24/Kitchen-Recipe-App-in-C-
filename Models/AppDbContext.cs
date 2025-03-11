using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using KitchenRecipesApp1.Models;

namespace KitchenRecipesApp1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipesStepsIngredientsAsoc> RecipesStepsIngredients { get; set; }
        public DbSet<UserRecipe> UsersRecipes { get; set; }


        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)       //faci override la o setare
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=kitchen;User ID=root;Password=app;");     //legatura cu mysql sv
        }

        
    }
}
