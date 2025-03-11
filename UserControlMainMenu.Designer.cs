namespace KitchenRecipesApp1
{
    partial class UserControlMainMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMainMenu));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonNewRecipe = new Button();
            labelGC = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1366, 768);
            tableLayoutPanel1.TabIndex = 2;
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
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button5, 0, 6);
            tableLayoutPanel2.Controls.Add(button4, 0, 5);
            tableLayoutPanel2.Controls.Add(button3, 0, 4);
            tableLayoutPanel2.Controls.Add(button2, 0, 3);
            tableLayoutPanel2.Controls.Add(button1, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonNewRecipe, 0, 1);
            tableLayoutPanel2.Controls.Add(labelGC, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(540, 762);
            tableLayoutPanel2.TabIndex = 10;
            tableLayoutPanel2.Resize += MainMenuResize;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.BackColor = Color.DarkGray;
            button5.Font = new Font("Segoe UI", 23F);
            button5.Location = new Point(113, 576);
            button5.Name = "button5";
            button5.Size = new Size(314, 82);
            button5.TabIndex = 17;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonExit_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = Color.DarkGray;
            button4.Font = new Font("Segoe UI", 23F);
            button4.Location = new Point(113, 481);
            button4.Name = "button4";
            button4.Size = new Size(314, 82);
            button4.TabIndex = 16;
            button4.Text = "LOG OUT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonLogOut_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Segoe UI", 23F);
            button3.Location = new Point(113, 386);
            button3.Name = "button3";
            button3.Size = new Size(314, 82);
            button3.TabIndex = 15;
            button3.Text = "SETTINGS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonSettings_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Segoe UI", 23F);
            button2.Location = new Point(113, 291);
            button2.Name = "button2";
            button2.Size = new Size(314, 82);
            button2.TabIndex = 14;
            button2.Text = "EDIT RECIPES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonEditRecipes_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 23F);
            button1.Location = new Point(113, 196);
            button1.Name = "button1";
            button1.Size = new Size(314, 82);
            button1.TabIndex = 13;
            button1.Text = "COOK IT!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonCookIt_Click;
            // 
            // buttonNewRecipe
            // 
            buttonNewRecipe.Anchor = AnchorStyles.None;
            buttonNewRecipe.AutoSize = true;
            buttonNewRecipe.BackColor = Color.DarkGray;
            buttonNewRecipe.Font = new Font("Segoe UI", 23F);
            buttonNewRecipe.Location = new Point(113, 101);
            buttonNewRecipe.Name = "buttonNewRecipe";
            buttonNewRecipe.Size = new Size(314, 82);
            buttonNewRecipe.TabIndex = 12;
            buttonNewRecipe.Text = "NEW RECIPE";
            buttonNewRecipe.UseVisualStyleBackColor = false;
            buttonNewRecipe.Click += buttonNewRecipe_Click;
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 762);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(958, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 762);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // UserControlMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlMainMenu";
            Size = new Size(1366, 768);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonNewRecipe;
        private Label labelGC;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
