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

namespace KitchenRecipesApp1
{
    public partial class UserControlCookIt : UserControl
    {
        public AppDbContext DbContext { get; set; }
        public UserControlCookIt()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
        }



        Recipe currentReadRecipe;
        private void comboBoxSelectRecipe_TextUpdate(object sender, EventArgs e)
        {


            //cautare reteta
            currentReadRecipe = DbContext.Recipes.FirstOrDefault(r => r.Name == comboBoxSelectRecipe.Text);

            //meniul se creaza in functie de reteta aleasa
            comboBoxSelectQuantity.Text = currentReadRecipe.Quantity.ToString();


            labelUnit.Text = currentReadRecipe.Unit;
            labelDescription.Text = currentReadRecipe.Description;


            //afisare meniu intreg
            labelSelectQuality.Visible = true;
            comboBoxSelectQuantity.Visible = true;
            labelUnit.Visible = true;
            buttonOK.Visible = true;




            comboBoxSelectRecipe.Enabled = false;


        }

        private void comboBoxSelectRecipe_MouseCaptureChanged(object sender, EventArgs e)
        {
            List<string> recipeList = new List<string>();
            recipeList = DbContext.Recipes.Where(r => r.Privacy == 1).Select(r => r.Name).ToList();

            List<string> privateRecipeLists = DbContext.Users.Where(u => u.Name == GeneralData.CurrentUser.Name)
                                                .SelectMany(u => u.UsersRecipes)
                                                .Select(ur => ur.Recipe.Name)
                                                .ToList();


            recipeList.AddRange(privateRecipeLists);
            recipeList = recipeList.Distinct().ToList();
            recipeList.Sort();

            comboBoxSelectRecipe.DataSource = recipeList;
            comboBoxSelectRecipe.SelectedIndexChanged += comboBoxSelectRecipe_TextUpdate;
        }

        public EventHandler ReturnClicked;
        private void buttonReturnToMainMenu_Click(object sender, EventArgs e)
        {
            ReturnClicked?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxSelectQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                //meniul se creaza in functie de cantitatea aleasa
                double f = Convert.ToDouble(comboBoxSelectQuantity.Text) / currentReadRecipe.Quantity;

                dataGridView1.DataSource = DbContext.Recipes.Where(r => r.RecipeID == currentReadRecipe.RecipeID)
                                                            .SelectMany(r => r.RecipesStepsIngredients)
                                                            .Select(rsi => new
                                                            {
                                                                Name = rsi.Ingredient.Name,
                                                                Quantity = Math.Round(rsi.Quantity * f, 2),
                                                                Unit = rsi.Unit
                                                            })
                                                            .ToList();
                //afisare final meniu
                dataGridView1.Visible = true;
                labelDescription.Visible = true;

                comboBoxSelectQuantity.Enabled = false;
                buttonOK.Enabled = false;

                buttonAddCookingSteps.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void GenerateSteps()
        {
            int stepCount = DbContext.RecipesStepsIngredients.Count(rsi => rsi.RecipeID == currentReadRecipe.RecipeID);
            tableLayoutPanelSteps.RowCount = stepCount;

            //tableLayoutPanelSteps.Height = 1000 * 25;

            tableLayoutPanelSteps.Controls.Clear();
            tableLayoutPanelSteps.RowStyles.Clear();


            for (int i = 0; i < 100; i++)
            {


                Label labelGC1 = new Label
                {
                    Text = $"Step {i + 1}",
                    BackColor = Color.Yellow,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                tableLayoutPanelSteps.Controls.Add(labelGC1, 0, i);

                tableLayoutPanelSteps.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            }
        }

        private void buttonAddCookingSteps_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            GenerateSteps();
            tabControl1.SelectedTab = tabPage2;
            buttonAddCookingSteps.Enabled = false;
        }

        private void panelScroll_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
