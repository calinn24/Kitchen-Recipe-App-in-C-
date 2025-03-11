using KitchenRecipesApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
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
    public partial class UserControlStepControl : UserControl
    {
        public AppDbContext DbContextI { get; set; }
        int tabCount = 1;
        public void NewStep(object sender, EventArgs e)
        {
            if (tabCount > 30)
            {
                MessageBox.Show("Too many steps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else CreateTab();
        }


        public EventHandler FinsihRecipeClickedToMenuEvent;
        public void FinsihRecipeClickedToMenuFunction(object sender, EventArgs e)
        {
            //verifica daca toate datele sunt corecte
            bool AllSaved = true;

            
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Controls[0] is UserControlStepModel stepModel)
                {
                    if (stepModel.IsDataCorrect() == false) AllSaved = false;
                }
            }

            if(AllSaved == true)
            {
                //salveaza datele din toate ferestrele step daca e totul ok
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    if (tabPage.Controls[0] is UserControlStepModel stepModel)
                    {
                        stepModel.SaveTabData();
                    }
                    

                }
                //schimba la meniul principal
                FinsihRecipeClickedToMenuEvent.Invoke(this, new EventArgs());
            }


        }



        
        public void CreateTab()
        {
            TabPage tabPage1 = new TabPage("Step " + tabCount);
            

            UserControlStepModel model1 = new UserControlStepModel
            {
                StepNB = tabCount,
                Dock = DockStyle.Fill,
                DbContext = DbContextI

            };
            model1.NewStepClicked += NewStep;       
            model1.FinsihRecipeClicked += FinsihRecipeClickedToMenuFunction;    //poate se modifica cand faci legatura cu form3
            tabPage1.Controls.Add(model1);

            tabControl1.TabPages.Add(tabPage1);
            tabControl1.SelectedTab = tabPage1;

            tabCount++;

        }


        public UserControlStepControl(AppDbContext context)
        {
            DbContextI = context;
            InitializeComponent();
            CreateTab();
        }




    }
}
