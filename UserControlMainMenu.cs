using Org.BouncyCastle.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenRecipesApp1
{
    public partial class UserControlMainMenu : UserControl
    {
        int initialWidth;
        public UserControlMainMenu()
        {
            InitializeComponent();
            initialWidth = tableLayoutPanel2.Width;
        }

        public event EventHandler NewRecipeClicked;
        private void buttonNewRecipe_Click(object sender, EventArgs e)
        {
            NewRecipeClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CookItClicked;
        private void buttonCookIt_Click(object sender, EventArgs e)
        {
            CookItClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler EditRecipesClicked;
        private void buttonEditRecipes_Click(object sender, EventArgs e)
        {
            EditRecipesClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SettingsClicked;
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler LogOutClicked;
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOutClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ExitClicked;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitClicked?.Invoke(this, EventArgs.Empty);
        }
        /*
        private void UCMM_Resize(object sender, EventArgs e)
        {
            int availableWidth = tableLayoutPanel2.Width;
            int availableHeight = tableLayoutPanel2.Height;

            int buttonWidth = (int)(availableWidth / 1.5);
            int buttonHeight = availableHeight / 8;

            float multiplier = availableWidth/ (float)initialWidth; //atentie! sa pui float a doua oara ca altfel nu merge
            float fontSize = buttonNewRecipe.Font.Size * multiplier;

            if (fontSize <= 23 | fontSize > 50)
            {
                fontSize = 23; // Folosește o dimensiune minimă validă
            }

            for (int i = 1; i < 7; i++)
            {
                Button buttonB = (Button) tableLayoutPanel2.GetControlFromPosition(0, i);
                if (buttonB != null)
                {
                    buttonB.Width = buttonWidth;
                    buttonB.Height = buttonHeight;
                    buttonB.Font = new Font(buttonB.Font.FontFamily, fontSize, buttonB.Font.Style);

                }
            }

        }
        */

        private void MainMenuResize(object sender, EventArgs e)
        {
            int availableWidth = tableLayoutPanel2.Width;
            int availableHeigth = tableLayoutPanel2.Height;


        }

     
    }
}
