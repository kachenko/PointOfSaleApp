
namespace PointOfSaleApp.Forms
{
    partial class AddProductForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.listProdLabel = new System.Windows.Forms.Label();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.prodCodeTextBox = new System.Windows.Forms.TextBox();
            this.prodCatComboBox = new System.Windows.Forms.ComboBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.productUnitLabel = new System.Windows.Forms.Label();
            this.prodUnitComboBox = new System.Windows.Forms.ComboBox();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(958, 136);
            this.mainPanel.TabIndex = 7;
            // 
            // positLabel
            // 
            this.positLabel.AutoSize = true;
            this.positLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.positLabel.Location = new System.Drawing.Point(120, 40);
            this.positLabel.Name = "positLabel";
            this.positLabel.Size = new System.Drawing.Size(70, 23);
            this.positLabel.TabIndex = 2;
            this.positLabel.Text = "Position";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameLabel.Location = new System.Drawing.Point(118, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(179, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name Surname";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::PointOfSaleApp.Properties.Resources.f291c20922ce1ff1878b13afc2a49f19;
            this.userPictureBox.Location = new System.Drawing.Point(3, 3);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(111, 130);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // listProdLabel
            // 
            this.listProdLabel.AutoSize = true;
            this.listProdLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listProdLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listProdLabel.Location = new System.Drawing.Point(12, 161);
            this.listProdLabel.Name = "listProdLabel";
            this.listProdLabel.Size = new System.Drawing.Size(137, 30);
            this.listProdLabel.TabIndex = 8;
            this.listProdLabel.Text = "Product List";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Location = new System.Drawing.Point(678, 195);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodNameTextBox.TabIndex = 9;
            // 
            // prodCodeTextBox
            // 
            this.prodCodeTextBox.Location = new System.Drawing.Point(678, 223);
            this.prodCodeTextBox.Name = "prodCodeTextBox";
            this.prodCodeTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCodeTextBox.TabIndex = 10;
            // 
            // prodCatComboBox
            // 
            this.prodCatComboBox.FormattingEnabled = true;
            this.prodCatComboBox.Location = new System.Drawing.Point(678, 251);
            this.prodCatComboBox.Name = "prodCatComboBox";
            this.prodCatComboBox.Size = new System.Drawing.Size(292, 24);
            this.prodCatComboBox.TabIndex = 11;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productNameLabel.Location = new System.Drawing.Point(493, 194);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(124, 23);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCodeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productCodeLabel.Location = new System.Drawing.Point(493, 222);
            this.productCodeLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(54, 23);
            this.productCodeLabel.TabIndex = 13;
            this.productCodeLabel.Text = "Code:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productCategoryLabel.Location = new System.Drawing.Point(493, 252);
            this.productCategoryLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(146, 23);
            this.productCategoryLabel.TabIndex = 14;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProductButton.Location = new System.Drawing.Point(885, 373);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(85, 55);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // removeProductButton
            // 
            this.removeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeProductButton.Location = new System.Drawing.Point(794, 373);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(85, 55);
            this.removeProductButton.TabIndex = 16;
            this.removeProductButton.Text = "REMOVE";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // productUnitLabel
            // 
            this.productUnitLabel.AutoSize = true;
            this.productUnitLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productUnitLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productUnitLabel.Location = new System.Drawing.Point(493, 280);
            this.productUnitLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productUnitLabel.Name = "productUnitLabel";
            this.productUnitLabel.Size = new System.Drawing.Size(45, 23);
            this.productUnitLabel.TabIndex = 18;
            this.productUnitLabel.Text = "Unit:";
            // 
            // prodUnitComboBox
            // 
            this.prodUnitComboBox.FormattingEnabled = true;
            this.prodUnitComboBox.Location = new System.Drawing.Point(678, 281);
            this.prodUnitComboBox.Name = "prodUnitComboBox";
            this.prodUnitComboBox.Size = new System.Drawing.Size(292, 24);
            this.prodUnitComboBox.TabIndex = 19;
            // 
            // categoryGridView
            // 
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryGridView.ColumnHeadersHeight = 29;
            this.categoryGridView.Location = new System.Drawing.Point(15, 194);
            this.categoryGridView.MultiSelect = false;
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowHeadersWidth = 51;
            this.categoryGridView.RowTemplate.Height = 24;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(431, 391);
            this.categoryGridView.TabIndex = 42;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.logoutToolStripMenuItem,
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
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.dishesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.categoryToolStripMenuItem.Text = "Categories";
            // 
            // dishesToolStripMenuItem
            // 
            this.dishesToolStripMenuItem.Name = "dishesToolStripMenuItem";
            this.dishesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.dishesToolStripMenuItem.Text = "Dishes";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.prodUnitComboBox);
            this.Controls.Add(this.productUnitLabel);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.prodCatComboBox);
            this.Controls.Add(this.prodCodeTextBox);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(this.listProdLabel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddProductForm";
            this.Text = "POS - Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label listProdLabel;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox prodCodeTextBox;
        private System.Windows.Forms.ComboBox prodCatComboBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Label productUnitLabel;
        private System.Windows.Forms.ComboBox prodUnitComboBox;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
    }
}