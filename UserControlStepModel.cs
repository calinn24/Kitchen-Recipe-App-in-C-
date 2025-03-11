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
using ZstdSharp.Unsafe;

namespace KitchenRecipesApp1
{

    public partial class UserControlStepModel : UserControl
    {

        public int StepNB { get; set; }

        public class IngredientAndData
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        }



        public BindingList<IngredientAndData> ingredientListExtended = new BindingList<IngredientAndData>();



        public AppDbContext DbContext { get; set; }
        public UserControlStepModel()
        {
            InitializeComponent();
            UploadUnitsInUnitComboBox();

        }


        private void UploadUnitsInUnitComboBox()
        {
            comboBoxUnit.DataSource = GeneralData.units;
        }


        public EventHandler NewStepClicked;
        private void buttonNewStep_Click(object sender, EventArgs e)
        {
            NewStepClicked?.Invoke(this, EventArgs.Empty);
        }


        public class IngredientNameComparer : IEqualityComparer<UserControlStepModel.IngredientAndData>
        {
            public bool Equals(UserControlStepModel.IngredientAndData x, UserControlStepModel.IngredientAndData y)
            {
                return x.Name == y.Name; // Replace with the actual property for the name
            }

            public int GetHashCode(UserControlStepModel.IngredientAndData obj)
            {
                return obj.Name.GetHashCode(); // Replace with the actual property for the name
            }
        }



        public EventHandler FinsihRecipeClicked;
        private void buttonFinishRecipe_Click(object sender, EventArgs e)
        {
            FinsihRecipeClicked?.Invoke(this, EventArgs.Empty);
            //SaveTabData();

        }


        public bool IsDataCorrect()
        {
            try
            {
                bool hasDuplicates = ingredientListExtended.AsEnumerable().Count() != ingredientListExtended.AsEnumerable().Distinct(new IngredientNameComparer()).Count();

                if (hasDuplicates)
                {
                    MessageBox.Show("Duplicate ingredients found. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTime.Text = string.Empty;
                return false;
            }
        }


        public void SaveTabData()
        {

            int time;
            if (textBoxTime.Text == string.Empty) time = 0;
            else time = Convert.ToInt32(textBoxTime.Text);




            var step = new Step
            {
                Timer = checkBoxTimer.Checked ? 1 : 0,
                Time = time,
                Description = richTextBoxDescription.Text
            };

            DbContext.Steps.Add(step);
            DbContext.SaveChanges();


            //adaugare RSI


            foreach (IngredientAndData iextended in ingredientListExtended)
            {

                Ingredient searchedIngredient = DbContext.Ingredients.FirstOrDefault(ing => ing.Name == iextended.Name);
                var rsi = new RecipesStepsIngredientsAsoc
                {
                    RecipeID = GeneralData.CurrentRecipe.RecipeID,
                    StepID = step.StepID,
                    IngredientID = searchedIngredient.IngredientID,
                    OrderNB = StepNB,
                    Quantity = iextended.Quantity,
                    Unit = iextended.Unit
                };

                DbContext.RecipesStepsIngredients.Add(rsi);
                DbContext.SaveChanges();

            }

        }


        private void CheckIfAllCompleted(object sender, EventArgs e)
        {
            if (comboBoxIngredient.Text != string.Empty & textBoxQuantity.Text != string.Empty & comboBoxUnit.Text != string.Empty) buttonAddIngredient.Enabled = true;
            else buttonAddIngredient.Enabled = false;
        }


        private void AddIngredient_Click(object sender, EventArgs e)
        {
            try
            {

                if (!DbContext.Ingredients.Any(i => i.Name == comboBoxIngredient.Text))
                {
                    //adauga ingredientul in baza de date daca nu exista

                    var ingredient = new Ingredient
                    {
                        Name = comboBoxIngredient.Text
                    };

                    DbContext.Ingredients.Add(ingredient);
                    DbContext.SaveChanges();
                }

                //adauga in grid si in lista locala de ingrediente
                var ingredient_extended = new IngredientAndData
                {
                    Name = comboBoxIngredient.Text.ToLower(),
                    Quantity = Convert.ToDouble(textBoxQuantity.Text),
                    Unit = comboBoxUnit.Text
                };

                ingredientListExtended.Add(ingredient_extended);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ingredientListExtended;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantity.Text = string.Empty;
            }



        }



        private void UploadIngredientsINComboBox(object sender, EventArgs e)
        {
            List<string> ingredientList = new List<string>();
            ingredientList = DbContext.Ingredients.Select(i => i.Name).ToList();
            comboBoxIngredient.DataSource = ingredientList;
        }

        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                labelTime.Visible = true;
                textBoxTime.Visible = true;
            }
            else
            {
                labelTime.Visible = false;
                textBoxTime.Visible = false;
                textBoxTime.Text = string.Empty;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int index = row.Index;


            var result = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);



            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(row);
                //ingredientListExtended.Remove(ingredientListExtended[index]);

            }
        }
    }
}
