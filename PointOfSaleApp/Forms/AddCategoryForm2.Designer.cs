﻿
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
            this.components = new System.ComponentModel.Container();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDBDataSet = new PointOfSaleApp.posDBDataSet();
            this.dishCategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dishCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateCategoryButton = new System.Windows.Forms.Button();
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
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.productDescrLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.prodCatDesTextBox = new System.Windows.Forms.TextBox();
            this.prodCatTextBox = new System.Windows.Forms.TextBox();
            this.listCatLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryIDLabel = new System.Windows.Forms.Label();
            this.prodCatIDTextBox = new System.Windows.Forms.TextBox();
            this.dishDishCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dishCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishTableAdapter = new PointOfSaleApp.posDBDataSetTableAdapters.DishTableAdapter();
            this.categoryTableAdapter = new PointOfSaleApp.posDBDataSetTableAdapters.CategoryTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDishCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryGridView
            // 
            this.categoryGridView.AutoGenerateColumns = false;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryGridView.ColumnHeadersHeight = 29;
            this.categoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.categoryGridView.DataSource = this.categoryBindingSource1;
            this.categoryGridView.Location = new System.Drawing.Point(17, 200);
            this.categoryGridView.MultiSelect = false;
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersWidth = 51;
            this.categoryGridView.RowTemplate.Height = 24;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(431, 391);
            this.categoryGridView.TabIndex = 41;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.categoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.posDBDataSet;
            // 
            // posDBDataSet
            // 
            this.posDBDataSet.DataSetName = "posDBDataSet";
            this.posDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishCategoryBindingSource2
            // 
            this.dishCategoryBindingSource2.DataMember = "DishCategory";
            this.dishCategoryBindingSource2.DataSource = this.posDBDataSet;
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateCategoryButton.Location = new System.Drawing.Point(794, 358);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.updateCategoryButton.TabIndex = 40;
            this.updateCategoryButton.Text = "UPDATE";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
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
            this.menuStrip1.TabIndex = 39;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // removeCategoryButton
            // 
            this.removeCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeCategoryButton.Location = new System.Drawing.Point(885, 358);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.removeCategoryButton.TabIndex = 38;
            this.removeCategoryButton.Text = "REMOVE";
            this.removeCategoryButton.UseVisualStyleBackColor = true;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addCategoryButton.Location = new System.Drawing.Point(703, 358);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.addCategoryButton.TabIndex = 37;
            this.addCategoryButton.Text = "ADD";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // productDescrLabel
            // 
            this.productDescrLabel.AutoSize = true;
            this.productDescrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productDescrLabel.Location = new System.Drawing.Point(473, 253);
            this.productDescrLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productDescrLabel.Name = "productDescrLabel";
            this.productDescrLabel.Size = new System.Drawing.Size(99, 23);
            this.productDescrLabel.TabIndex = 36;
            this.productDescrLabel.Text = "Description:";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryNameLabel.Location = new System.Drawing.Point(473, 225);
            this.categoryNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(133, 23);
            this.categoryNameLabel.TabIndex = 35;
            this.categoryNameLabel.Text = "Category Name:";
            // 
            // prodCatDesTextBox
            // 
            this.prodCatDesTextBox.Location = new System.Drawing.Point(678, 256);
            this.prodCatDesTextBox.Name = "prodCatDesTextBox";
            this.prodCatDesTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatDesTextBox.TabIndex = 34;
            // 
            // prodCatTextBox
            // 
            this.prodCatTextBox.Location = new System.Drawing.Point(678, 228);
            this.prodCatTextBox.Name = "prodCatTextBox";
            this.prodCatTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatTextBox.TabIndex = 33;
            this.prodCatTextBox.TextChanged += new System.EventHandler(this.prodCatTextBox_TextChanged);
            this.prodCatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prodCatTextBox_KeyPress);
            // 
            // listCatLabel
            // 
            this.listCatLabel.AutoSize = true;
            this.listCatLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listCatLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listCatLabel.Location = new System.Drawing.Point(12, 167);
            this.listCatLabel.Name = "listCatLabel";
            this.listCatLabel.Size = new System.Drawing.Size(151, 30);
            this.listCatLabel.TabIndex = 32;
            this.listCatLabel.Text = "Category List";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(958, 136);
            this.mainPanel.TabIndex = 30;
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
            // categoryIDLabel
            // 
            this.categoryIDLabel.AutoSize = true;
            this.categoryIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryIDLabel.Location = new System.Drawing.Point(473, 197);
            this.categoryIDLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.categoryIDLabel.Name = "categoryIDLabel";
            this.categoryIDLabel.Size = new System.Drawing.Size(30, 23);
            this.categoryIDLabel.TabIndex = 43;
            this.categoryIDLabel.Text = "ID:";
            // 
            // prodCatIDTextBox
            // 
            this.prodCatIDTextBox.Enabled = false;
            this.prodCatIDTextBox.Location = new System.Drawing.Point(678, 200);
            this.prodCatIDTextBox.Name = "prodCatIDTextBox";
            this.prodCatIDTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatIDTextBox.TabIndex = 42;
            this.prodCatIDTextBox.Text = "0";
            // 
            // dishCategoryBindingSource1
            // 
            this.dishCategoryBindingSource1.DataMember = "DishCategory";
            this.dishCategoryBindingSource1.DataSource = this.posDBDataSet;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.posDBDataSet;
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.posDBDataSet;
            // 
            // AddCategoryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.categoryIDLabel);
            this.Controls.Add(this.prodCatIDTextBox);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.updateCategoryButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.productDescrLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.prodCatDesTextBox);
            this.Controls.Add(this.prodCatTextBox);
            this.Controls.Add(this.listCatLabel);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddCategoryForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Add Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategoryForm2_FormClosing);
            this.Load += new System.EventHandler(this.AddCategoryForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDishCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.Button updateCategoryButton;
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
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label productDescrLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox prodCatDesTextBox;
        private System.Windows.Forms.TextBox prodCatTextBox;
        private System.Windows.Forms.Label listCatLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        //private posDBDataSetTableAdapters.DishCategoryTableAdapter dishCategoryTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label categoryIDLabel;
        private System.Windows.Forms.TextBox prodCatIDTextBox;
        private System.Windows.Forms.BindingSource dishDishCategoryBindingSource1;
        //private posDBDataSet1 posDBDataSet1;
        private System.Windows.Forms.BindingSource dishCategoryBindingSource;
        //private posDBDataSet1TableAdapters.DishCategoryTableAdapter dishCategoryTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private posDBDataSet posDBDataSet;
        private System.Windows.Forms.BindingSource dishCategoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private posDBDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        private System.Windows.Forms.BindingSource dishCategoryBindingSource2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private posDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
    }
}