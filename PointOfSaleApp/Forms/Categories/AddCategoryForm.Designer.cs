
namespace PointOfSaleApp.Forms
{
    partial class AddCategoryForm2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm2));
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.productDescrLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.prodCatDesTextBox = new System.Windows.Forms.TextBox();
            this.prodCatTextBox = new System.Windows.Forms.TextBox();
            this.listCatLabel = new System.Windows.Forms.Label();
            this.categoryIDLabel = new System.Windows.Forms.Label();
            this.prodCatIDTextBox = new System.Windows.Forms.TextBox();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.userLogoControl1 = new PointOfSaleApp.UserLogoControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(520, 224);
            this.categoryGridView.MultiSelect = false;
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersWidth = 51;
            this.categoryGridView.RowTemplate.Height = 24;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(431, 367);
            this.categoryGridView.TabIndex = 41;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.BackColor = System.Drawing.Color.SandyBrown;
            this.updateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateCategoryButton.Location = new System.Drawing.Point(329, 428);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.updateCategoryButton.TabIndex = 40;
            this.updateCategoryButton.Text = "UPDATE";
            this.updateCategoryButton.UseVisualStyleBackColor = false;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.BackColor = System.Drawing.Color.Tomato;
            this.removeCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCategoryButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.removeCategoryButton.Location = new System.Drawing.Point(420, 428);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.removeCategoryButton.TabIndex = 38;
            this.removeCategoryButton.Text = "REMOVE";
            this.removeCategoryButton.UseVisualStyleBackColor = false;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addCategoryButton.Location = new System.Drawing.Point(238, 428);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.addCategoryButton.TabIndex = 37;
            this.addCategoryButton.Text = "ADD";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // productDescrLabel
            // 
            this.productDescrLabel.AutoSize = true;
            this.productDescrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productDescrLabel.Location = new System.Drawing.Point(33, 349);
            this.productDescrLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productDescrLabel.Name = "productDescrLabel";
            this.productDescrLabel.Size = new System.Drawing.Size(110, 25);
            this.productDescrLabel.TabIndex = 36;
            this.productDescrLabel.Text = "Description:";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryNameLabel.Location = new System.Drawing.Point(33, 321);
            this.categoryNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(147, 25);
            this.categoryNameLabel.TabIndex = 35;
            this.categoryNameLabel.Text = "Category Name:";
            // 
            // prodCatDesTextBox
            // 
            this.prodCatDesTextBox.Location = new System.Drawing.Point(213, 354);
            this.prodCatDesTextBox.Multiline = true;
            this.prodCatDesTextBox.Name = "prodCatDesTextBox";
            this.prodCatDesTextBox.Size = new System.Drawing.Size(292, 68);
            this.prodCatDesTextBox.TabIndex = 34;
            // 
            // prodCatTextBox
            // 
            this.prodCatTextBox.Location = new System.Drawing.Point(213, 326);
            this.prodCatTextBox.Name = "prodCatTextBox";
            this.prodCatTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatTextBox.TabIndex = 33;
            // 
            // listCatLabel
            // 
            this.listCatLabel.AutoSize = true;
            this.listCatLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCatLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listCatLabel.Location = new System.Drawing.Point(515, 191);
            this.listCatLabel.Name = "listCatLabel";
            this.listCatLabel.Size = new System.Drawing.Size(170, 32);
            this.listCatLabel.TabIndex = 32;
            this.listCatLabel.Text = "Category List:";
            // 
            // categoryIDLabel
            // 
            this.categoryIDLabel.AutoSize = true;
            this.categoryIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryIDLabel.Location = new System.Drawing.Point(33, 293);
            this.categoryIDLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.categoryIDLabel.Name = "categoryIDLabel";
            this.categoryIDLabel.Size = new System.Drawing.Size(34, 25);
            this.categoryIDLabel.TabIndex = 43;
            this.categoryIDLabel.Text = "ID:";
            // 
            // prodCatIDTextBox
            // 
            this.prodCatIDTextBox.Enabled = false;
            this.prodCatIDTextBox.Location = new System.Drawing.Point(213, 298);
            this.prodCatIDTextBox.Name = "prodCatIDTextBox";
            this.prodCatIDTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatIDTextBox.TabIndex = 42;
            this.prodCatIDTextBox.Text = "0";
            // 
            // clearDataButton
            // 
            this.clearDataButton.BackColor = System.Drawing.Color.PeachPuff;
            this.clearDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDataButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDataButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clearDataButton.Location = new System.Drawing.Point(12, 428);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(85, 55);
            this.clearDataButton.TabIndex = 44;
            this.clearDataButton.Text = "CLEAR DATA";
            this.clearDataButton.UseVisualStyleBackColor = false;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // userLogoControl1
            // 
            this.userLogoControl1.Location = new System.Drawing.Point(0, 31);
            this.userLogoControl1.Name = "userLogoControl1";
            this.userLogoControl1.Size = new System.Drawing.Size(982, 157);
            this.userLogoControl1.TabIndex = 45;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.fileToolStripMenuItem.Text = "Session";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newSessionToolStripMenuItem.Text = "New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // AddCategoryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userLogoControl1);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.categoryIDLabel);
            this.Controls.Add(this.prodCatIDTextBox);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.updateCategoryButton);
            this.Controls.Add(this.removeCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.productDescrLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.prodCatDesTextBox);
            this.Controls.Add(this.prodCatTextBox);
            this.Controls.Add(this.listCatLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCategoryForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategoryForm2_FormClosing);
            this.Load += new System.EventHandler(this.AddCategoryForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label productDescrLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox prodCatDesTextBox;
        private System.Windows.Forms.TextBox prodCatTextBox;
        private System.Windows.Forms.Label listCatLabel;
        //private posDBDataSetTableAdapters.DishCategoryTableAdapter dishCategoryTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label categoryIDLabel;
        private System.Windows.Forms.TextBox prodCatIDTextBox;
        private System.Windows.Forms.Button clearDataButton;
        private UserLogoControl userLogoControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}