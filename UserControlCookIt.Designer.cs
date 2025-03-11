namespace KitchenRecipesApp1
{
    partial class UserControlCookIt
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            comboBoxSelectRecipe = new ComboBox();
            labelSelectRecipe = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonOK = new Button();
            labelUnit = new Label();
            comboBoxSelectQuantity = new ComboBox();
            labelSelectQuality = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            labelDescription = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelGC = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            buttonReturnToMainMenu = new Button();
            buttonAddCookingSteps = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            panelScroll = new Panel();
            tableLayoutPanelSteps = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panelScroll.SuspendLayout();
            tableLayoutPanelSteps.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1366, 768);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(34, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1328, 760);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Recipe Tab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1322, 754);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(161, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 748);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 72);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Size = new Size(998, 579);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel7.Controls.Add(comboBoxSelectRecipe, 1, 0);
            tableLayoutPanel7.Controls.Add(labelSelectRecipe, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(992, 51);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // comboBoxSelectRecipe
            // 
            comboBoxSelectRecipe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectRecipe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectRecipe.Font = new Font("Segoe UI", 16F);
            comboBoxSelectRecipe.FormattingEnabled = true;
            comboBoxSelectRecipe.Location = new Point(379, 3);
            comboBoxSelectRecipe.Name = "comboBoxSelectRecipe";
            comboBoxSelectRecipe.Size = new Size(529, 53);
            comboBoxSelectRecipe.TabIndex = 12;
            comboBoxSelectRecipe.MouseCaptureChanged += comboBoxSelectRecipe_MouseCaptureChanged;
            // 
            // labelSelectRecipe
            // 
            labelSelectRecipe.AutoSize = true;
            labelSelectRecipe.BackColor = Color.SeaGreen;
            labelSelectRecipe.Dock = DockStyle.Right;
            labelSelectRecipe.Font = new Font("Segoe UI", 16F);
            labelSelectRecipe.Location = new Point(158, 0);
            labelSelectRecipe.Name = "labelSelectRecipe";
            labelSelectRecipe.Size = new Size(215, 51);
            labelSelectRecipe.TabIndex = 2;
            labelSelectRecipe.Text = "Select Recipe:";
            labelSelectRecipe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel5.Controls.Add(buttonOK, 3, 0);
            tableLayoutPanel5.Controls.Add(labelUnit, 2, 0);
            tableLayoutPanel5.Controls.Add(comboBoxSelectQuantity, 1, 0);
            tableLayoutPanel5.Controls.Add(labelSelectQuality, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 60);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(992, 51);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.BackColor = Color.LightGray;
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Font = new Font("Segoe UI", 15F);
            buttonOK.Location = new Point(814, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(93, 45);
            buttonOK.TabIndex = 17;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Visible = false;
            buttonOK.Click += comboBoxSelectQuantity_SelectedIndexChanged;
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.BackColor = Color.SeaGreen;
            labelUnit.Dock = DockStyle.Fill;
            labelUnit.Font = new Font("Segoe UI", 16F);
            labelUnit.Location = new Point(656, 0);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(152, 51);
            labelUnit.TabIndex = 13;
            labelUnit.TextAlign = ContentAlignment.MiddleCenter;
            labelUnit.Visible = false;
            // 
            // comboBoxSelectQuantity
            // 
            comboBoxSelectQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectQuantity.Font = new Font("Segoe UI", 16F);
            comboBoxSelectQuantity.FormattingEnabled = true;
            comboBoxSelectQuantity.Location = new Point(379, 3);
            comboBoxSelectQuantity.Name = "comboBoxSelectQuantity";
            comboBoxSelectQuantity.Size = new Size(271, 53);
            comboBoxSelectQuantity.TabIndex = 12;
            comboBoxSelectQuantity.Visible = false;
            // 
            // labelSelectQuality
            // 
            labelSelectQuality.AutoSize = true;
            labelSelectQuality.BackColor = Color.SeaGreen;
            labelSelectQuality.Dock = DockStyle.Right;
            labelSelectQuality.Font = new Font("Segoe UI", 16F);
            labelSelectQuality.Location = new Point(131, 0);
            labelSelectQuality.Name = "labelSelectQuality";
            labelSelectQuality.Size = new Size(242, 51);
            labelSelectQuality.TabIndex = 3;
            labelSelectQuality.Text = "Select Quantity:";
            labelSelectQuality.TextAlign = ContentAlignment.MiddleRight;
            labelSelectQuality.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel6.Controls.Add(labelDescription, 2, 0);
            tableLayoutPanel6.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 117);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(992, 459);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.PeachPuff;
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Font = new Font("Segoe UI", 16F);
            labelDescription.Location = new Point(498, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(410, 459);
            labelDescription.TabIndex = 9;
            labelDescription.TextAlign = ContentAlignment.MiddleCenter;
            labelDescription.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(82, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(410, 453);
            dataGridView1.TabIndex = 10;
            dataGridView1.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(labelGC, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(998, 72);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // labelGC
            // 
            labelGC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelGC.Font = new Font("Segoe Print", 20F);
            labelGC.Location = new Point(3, 0);
            labelGC.Name = "labelGC";
            labelGC.Size = new Size(992, 72);
            labelGC.TabIndex = 1;
            labelGC.Text = "Gourmet Caravan";
            labelGC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 651);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(998, 97);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 5;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel13.Controls.Add(buttonReturnToMainMenu, 2, 0);
            tableLayoutPanel13.Controls.Add(buttonAddCookingSteps, 3, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(992, 91);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // buttonReturnToMainMenu
            // 
            buttonReturnToMainMenu.AutoSize = true;
            buttonReturnToMainMenu.BackColor = Color.DimGray;
            buttonReturnToMainMenu.Dock = DockStyle.Fill;
            buttonReturnToMainMenu.Font = new Font("Segoe UI", 10F);
            buttonReturnToMainMenu.Location = new Point(617, 3);
            buttonReturnToMainMenu.Name = "buttonReturnToMainMenu";
            buttonReturnToMainMenu.Size = new Size(142, 85);
            buttonReturnToMainMenu.TabIndex = 19;
            buttonReturnToMainMenu.Text = "RETURN TO MAIN MENU";
            buttonReturnToMainMenu.UseVisualStyleBackColor = false;
            buttonReturnToMainMenu.Click += buttonReturnToMainMenu_Click;
            // 
            // buttonAddCookingSteps
            // 
            buttonAddCookingSteps.AutoSize = true;
            buttonAddCookingSteps.BackColor = Color.LightGray;
            buttonAddCookingSteps.Dock = DockStyle.Fill;
            buttonAddCookingSteps.Enabled = false;
            buttonAddCookingSteps.Font = new Font("Segoe UI", 9F);
            buttonAddCookingSteps.Location = new Point(765, 3);
            buttonAddCookingSteps.Name = "buttonAddCookingSteps";
            buttonAddCookingSteps.Size = new Size(142, 85);
            buttonAddCookingSteps.TabIndex = 16;
            buttonAddCookingSteps.Text = "START STEP MENU";
            buttonAddCookingSteps.UseVisualStyleBackColor = false;
            buttonAddCookingSteps.Click += buttonAddCookingSteps_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel8);
            tabPage2.Location = new Point(34, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1328, 760);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Step Tab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel8.Controls.Add(panel2, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1322, 754);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(tableLayoutPanel9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(161, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 748);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel9.Controls.Add(panelScroll, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(998, 748);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // panelScroll
            // 
            panelScroll.AutoScroll = true;
            panelScroll.Controls.Add(tableLayoutPanelSteps);
            panelScroll.Dock = DockStyle.Fill;
            panelScroll.Location = new Point(82, 3);
            panelScroll.Name = "panelScroll";
            panelScroll.Size = new Size(832, 742);
            panelScroll.TabIndex = 1;
            panelScroll.Paint += panelScroll_Paint;
            // 
            // tableLayoutPanelSteps
            // 
            tableLayoutPanelSteps.AutoSize = true;
            tableLayoutPanelSteps.ColumnCount = 1;
            tableLayoutPanelSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSteps.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanelSteps.Location = new Point(0, 0);
            tableLayoutPanelSteps.Name = "tableLayoutPanelSteps";
            tableLayoutPanelSteps.RowCount = 2;
            tableLayoutPanelSteps.RowStyles.Add(new RowStyle(SizeType.Absolute, 181F));
            tableLayoutPanelSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSteps.Size = new Size(832, 2500);
            tableLayoutPanelSteps.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(826, 175);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // UserControlCookIt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UserControlCookIt";
            Size = new Size(1366, 768);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            panelScroll.ResumeLayout(false);
            panelScroll.PerformLayout();
            tableLayoutPanelSteps.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private ComboBox comboBoxSelectRecipe;
        private Label labelSelectRecipe;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonOK;
        private Label labelUnit;
        private ComboBox comboBoxSelectQuantity;
        private Label labelSelectQuality;
        private TableLayoutPanel tableLayoutPanel6;
        private Label labelDescription;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelGC;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel13;
        private Button buttonReturnToMainMenu;
        private Button buttonAddCookingSteps;
        private ColorDialog colorDialog1;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panelScroll;
        private TableLayoutPanel tableLayoutPanelSteps;
        private TableLayoutPanel tableLayoutPanel10;
    }
}
