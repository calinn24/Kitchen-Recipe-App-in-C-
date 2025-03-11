using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenRecipesApp1.Models;

namespace KitchenRecipesApp1
{
    public partial class UserControlRegister : UserControl
    {
        
        public UserControlRegister()
        {
            InitializeComponent();
           
        }

        public AppDbContext DbContext { get; set; }



        private void RegisterUser(string name, string password)
        {

            var user = new User { Name = name, Password = password };

            DbContext.Users.Add(user);
            DbContext.SaveChanges();
            
        }

        public EventHandler RegisterClicked;
        private void btnRegisterClicked(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                bool UserExists = DbContext.Users.Any(x => x.Name == textBoxUsername.Text);

                if(!UserExists)
                {
                    RegisterUser(textBoxUsername.Text, textBoxPassword.Text);
                    MessageBox.Show("User Created Successfully!");
                    RegisterClicked?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("User already exists.");
                }

                
            }
            else
            {
                
                MessageBox.Show("The password and confirmation password do not match. Please try again.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            


        }
    }
}
