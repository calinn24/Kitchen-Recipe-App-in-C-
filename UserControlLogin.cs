using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenRecipesApp1.Models;

namespace KitchenRecipesApp1
{
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        public AppDbContext DbContext { get; set; }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelOr = new Label();
            buttonLogin = new Button();
            linkLabelFP = new LinkLabel();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelLogin = new Label();
            labelGC = new Label();
            labelPassword = new Label();
            buttonRegister = new Button();
            textBoxUsername = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1366, 768);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.christian_mackie_cc0Gg3BegjE_unsplash;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 762);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.taylor_kiser_1YhSMc1IywE_unsplash2;
            pictureBox2.Location = new Point(958, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 762);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(412, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 762);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelOr, 0, 8);
            tableLayoutPanel2.Controls.Add(buttonLogin, 0, 7);
            tableLayoutPanel2.Controls.Add(linkLabelFP, 0, 6);
            tableLayoutPanel2.Controls.Add(textBoxPassword, 0, 5);
            tableLayoutPanel2.Controls.Add(labelUsername, 0, 2);
            tableLayoutPanel2.Controls.Add(labelLogin, 0, 1);
            tableLayoutPanel2.Controls.Add(labelGC, 0, 0);
            tableLayoutPanel2.Controls.Add(labelPassword, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonRegister, 0, 9);
            tableLayoutPanel2.Controls.Add(textBoxUsername, 0, 3);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Size = new Size(540, 762);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // labelOr
            // 
            labelOr.Anchor = AnchorStyles.None;
            labelOr.AutoSize = true;
            labelOr.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            labelOr.Location = new Point(255, 573);
            labelOr.Name = "labelOr";
            labelOr.Size = new Size(29, 25);
            labelOr.TabIndex = 8;
            labelOr.Text = "or";
            labelOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.AutoSize = true;
            buttonLogin.BackColor = Color.DarkGray;
            buttonLogin.Font = new Font("Segoe UI", 15F);
            buttonLogin.Location = new Point(186, 473);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(168, 52);
            buttonLogin.TabIndex = 11;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += btnLoginClicked;
            // 
            // linkLabelFP
            // 
            linkLabelFP.Anchor = AnchorStyles.None;
            linkLabelFP.AutoSize = true;
            linkLabelFP.Location = new Point(193, 399);
            linkLabelFP.Name = "linkLabelFP";
            linkLabelFP.Size = new Size(154, 25);
            linkLabelFP.TabIndex = 10;
            linkLabelFP.TabStop = true;
            linkLabelFP.Text = "Forgot Password?";
            linkLabelFP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(72, 355);
            textBoxPassword.MaxLength = 15;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(396, 31);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Left;
            labelUsername.Font = new Font("Segoe UI", 16F);
            labelUsername.Location = new Point(3, 234);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(226, 41);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "       Username";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14F);
            labelLogin.Location = new Point(227, 145);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(85, 38);
            labelLogin.TabIndex = 4;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGC
            // 
            labelGC.Anchor = AnchorStyles.None;
            labelGC.Font = new Font("Segoe Print", 20F);
            labelGC.Location = new Point(3, 0);
            labelGC.Name = "labelGC";
            labelGC.Size = new Size(534, 95);
            labelGC.TabIndex = 0;
            labelGC.Text = "Gourmet Caravan";
            labelGC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Dock = DockStyle.Left;
            labelPassword.Font = new Font("Segoe UI", 16F);
            labelPassword.Location = new Point(3, 311);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(216, 41);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "       Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.BackColor = Color.DarkGray;
            buttonRegister.Font = new Font("Segoe UI", 15F);
            buttonRegister.Location = new Point(186, 659);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(168, 52);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += btnRegister_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(72, 278);
            textBoxUsername.MaxLength = 15;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(396, 31);
            textBoxUsername.TabIndex = 8;
            // 
            // UserControlLogin
            // 
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlLogin";
            Size = new Size(1366, 768);
            tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelOr;
        private Button buttonLogin;
        private LinkLabel linkLabelFP;
        public TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelLogin;
        private Label labelGC;
        public TextBox textBoxUsername;
        private Label labelPassword;
        private Button buttonRegister;



        // Click REGISTER method
        public event EventHandler RegisterClicked;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Declanșează evenimentul
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        // Click LOGIN method

        public event EventHandler LoginClicked;
        private void btnLoginClicked(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);


        }


    }
}
