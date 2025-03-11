using KitchenRecipesApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenRecipesApp1.Models;

namespace KitchenRecipesApp1
{
    public partial class UserControlNewRecipe : UserControl
    {
        public UserControlNewRecipe()
        {
            InitializeComponent();
        }
        public AppDbContext DbContext { get; set; }


        int successful = 0;
        private void buttonCreateRecipe(object sender, EventArgs e)
        {
            //reteta trebuie sa fie unica printre cele publice si printre cele ale user ului
            bool RecipeExistsInPublic = DbContext.Recipes.Any(x => (x.Name == textBoxRecipeName.Text & x.Privacy == 1));

            bool RecipeExistsPrivateUser = DbContext.Users.Where(u => u.Name == GeneralData.CurrentUser.Name)       //querry: utilizatorul cautat
                                                .SelectMany(u => u.UsersRecipes)                                    //querry: u LJ ur LJ r pt utilizatorul cautat
                                                .Select(ur => ur.Recipe)                                            //querry: doar retele utilizatorului cautat
                                                .Any(r => r.Name == textBoxRecipeName.Text);                        //exista reteta cu numele introdus la tastatura?
                                                                                                                    //ai scapat de problema cautarii in tot tabelul retelor, unde pot exista dubluri

            if (RecipeExistsInPublic | RecipeExistsPrivateUser)
            {
                MessageBox.Show("Recipe already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                successful = 0;
            }
            else
            {
                try
                {
                    int privacy;
                    if (radioButtonAnybody.Checked) privacy = 1;
                    else privacy = 0;

                    double quantity;
                    if (textBoxQuantity.Text == string.Empty) quantity = 0;
                    else quantity = Convert.ToDouble(textBoxQuantity.Text);

                    var recipe = new Recipe
                    {

                        Name = textBoxRecipeName.Text,
                        Quantity = Math.Round(quantity, 2),
                        Unit = comboBoxUnit.Text,
                        Description = richTextBoxDescription.Text,
                        Privacy = privacy


                    };

                    DbContext.Recipes.Add(recipe);
                    DbContext.SaveChanges();


                    var ourRecipe = DbContext.Recipes.FirstOrDefault(r => r.Name == recipe.Name);

                    var userRecipe = new UserRecipe
                    {
                        UserID = GeneralData.CurrentUser.UserID,
                        RecipeID = ourRecipe.RecipeID
                    };


                    GeneralData.CurrentRecipe = ourRecipe;

                    DbContext.UsersRecipes.Add(userRecipe);
                    DbContext.SaveChanges();


                    //MessageBox.Show("Recipe Created Successfully!");
                    successful = 1;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Please enter a valid number. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    successful = 0;
                }
               
                

            }
        }//SELECT * FROM users NATURAL LEFT JOIN usersrecipes NATURAL LEFT JOIN recipes WHERE users.Name==fabi

        public EventHandler NextClicked;
        public void buttonNextClicked(object sender, EventArgs e)
        {
            buttonCreateRecipe(this, EventArgs.Empty);
            if (successful == 1) NextClicked?.Invoke(this, EventArgs.Empty);
        }

        public EventHandler FinsihClicked;
        public void buttonFinishClicked(object sender, EventArgs e)
        {
            buttonCreateRecipe(this, EventArgs.Empty);
            if (successful == 1) FinishClicked?.Invoke(this, EventArgs.Empty);
        }



        public void CheckCompletedFields(object sender, EventArgs e)
        {
            
            if ((textBoxRecipeName.Text != string.Empty) & (radioButtonAnybody.Checked | radioButtonJustMe.Checked) & (textBoxQuantity.Text != string.Empty) & (comboBoxUnit.Text != string.Empty))
            {
                buttonAddCookingSteps.Enabled = true;
                buttonFinishRecipeWithoutAddingCookingSteps.Enabled = true;
            }
            else
            {
                buttonAddCookingSteps.Enabled = false;
                buttonFinishRecipeWithoutAddingCookingSteps.Enabled = false;
            }
        }


        public void CheckIfQuantityIsNumber(object sender, EventArgs e)
        {


            if (!decimal.TryParse(textBoxQuantity.Text, out _))
            {
                MessageBox.Show("Please enter a valid number. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantity.Text = string.Empty;
            }

        }

        public EventHandler ReturnClicked;
        private void buttonReturn(object sender, EventArgs e)
        {
            ReturnClicked?.Invoke(this, EventArgs.Empty);
        }

        public EventHandler FinishClicked;
        private void buttonFinish(object sender, EventArgs e)
        {
            FinishClicked?.Invoke(this, EventArgs.Empty);
        }

        
    }
}
