using KitchenRecipesApp1.Models;
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
    public partial class Form3 : Form
    {
        private AppDbContext _context = new AppDbContext();  //one context for all user controls
            
        public Form3()      //constructor of the form 
        {
            //_context = 
            InitializeComponent();
            
            ShowUserControlLogin(this, EventArgs.Empty);
        }



        // SHOWING THE MENUs




        //LOGIN MENU
        private UserControlLogin login;
        public void ShowUserControlLogin(object sender, EventArgs e)
        {
            Controls.Clear();
            login = new UserControlLogin
            {
                DbContext = _context,
                Dock = DockStyle.Fill

            };

            login.RegisterClicked += ShowUserControlRegister;      //when you click REGISTER, you go to the register menu     
            login.LoginClicked += OnLoginClicked;

            Controls.Add(login);


        }

        //intermediary method to bond the Event to its purpose: changing the menu from Login to MainMenu
        private void OnLoginClicked(object sender, EventArgs e)
        {
            //var userControlLoginEX = sender as UserControlLogin;

            var user = _context.Users.FirstOrDefault(u => u.Name == login.textBoxUsername.Text);

            try
            {

                if (login.textBoxPassword.Text == user.Password)
                {
                    ShowUserControlMainMenu(this, EventArgs.Empty);
                    GeneralData.CurrentUser = user;
    }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        //REGISTER MENU
        private void ShowUserControlRegister(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlRegister register = new UserControlRegister
            {
                DbContext = _context,
                Dock = DockStyle.Fill
            };
            register.RegisterClicked += ShowUserControlLogin;
            Controls.Add(register);
        }



        //MAIN MENU

        private void ShowUserControlMainMenu(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlMainMenu menu = new UserControlMainMenu
            {
                Dock = DockStyle.Fill
            };
            menu.NewRecipeClicked += ShowUserControlNewRecipe;
            menu.CookItClicked += ShowUserControlCookIt;
            menu.EditRecipesClicked += ShowUserControlEditRecipes;
            menu.SettingsClicked += ShowUserControlSettings;
            menu.LogOutClicked += ShowUserControlLogin;
            menu.ExitClicked += ExitApp;


            Controls.Add(menu);
        }

        private void E(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        //NEW RECIPE

        private void ShowUserControlNewRecipe (object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlNewRecipe newrecipe = new UserControlNewRecipe
            {
                Dock = DockStyle.Fill,
                DbContext = _context
            };
            newrecipe.NextClicked += ShowUserControlStepControl;
            newrecipe.ReturnClicked += ShowUserControlMainMenu;
            newrecipe.FinishClicked += ShowUserControlMainMenu;
            
            Controls.Add(newrecipe);
        }


        //COOK IT
        private void ShowUserControlCookIt(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlCookIt cookit = new UserControlCookIt
            {
                Dock = DockStyle.Fill,
                DbContext = _context
            };
            cookit.ReturnClicked += ShowUserControlMainMenu;
            Controls.Add(cookit);
        }


        //EDIT RECIPE

        private void ShowUserControlEditRecipes(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlEditRecipes editrecipes = new UserControlEditRecipes
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(editrecipes);
        }



        //SETTINGS
        private void ShowUserControlSettings(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlSettings settings = new UserControlSettings
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(settings);
        }

        //EXIT
        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit(); //nu era nevoie ca functia sa fie executata aici, mergea direct in uc, dar am zis ca "orice are legatura cu
                                    //schimbul de uc sa fie in form, in acest caz le inchide pe toate
        }


        //STEP CONTROL MENU
        private void ShowUserControlStepControl(object sender, EventArgs e)
        {
            Controls.Clear();
            UserControlStepControl stepcontrol = new UserControlStepControl(_context)       //daca nu treceam contextul ca si parametru, crea deja fiecare tab step model, si abia apoi mai initializa proprietatea cu contextul, ceea ce era prea tarziu, functia de pasare a contextului a fost deja apelata pt tab1
            {
                Dock = DockStyle.Fill,
                //DbContextI = _context
            };
            stepcontrol.FinsihRecipeClickedToMenuEvent += ShowUserControlMainMenu;

            Controls.Add(stepcontrol);
        }
    }
}
