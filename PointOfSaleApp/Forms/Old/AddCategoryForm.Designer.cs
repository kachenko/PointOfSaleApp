
namespace PointOfSaleApp.Forms
{
    partial class AddCategoryForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.listCatLabel = new System.Windows.Forms.Label();
            this.listCatView = new System.Windows.Forms.ListView();
            this.prodIdColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNameColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodDescColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.productDescrLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.prodCatDesTextBox = new System.Windows.Forms.TextBox();
            this.prodCatTextBox = new System.Windows.Forms.TextBox();
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
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            //this.dishCategoryDataSet = new PointOfSaleApp.DishCategoryDataSet();
            this.dishCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dishCategoryTableAdapter = new PointOfSaleApp.DishCategoryDataSetTableAdapters.DishCategoryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dishCategoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource)).BeginInit();
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
            this.mainPanel.TabIndex = 8;
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
            // listCatLabel
            // 
            this.listCatLabel.AutoSize = true;
            this.listCatLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listCatLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listCatLabel.Location = new System.Drawing.Point(12, 161);
            this.listCatLabel.Name = "listCatLabel";
            this.listCatLabel.Size = new System.Drawing.Size(151, 30);
            this.listCatLabel.TabIndex = 10;
            this.listCatLabel.Text = "Category List";
            // 
            // listCatView
            // 
            this.listCatView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodIdColHead,
            this.prodNameColHead,
            this.prodDescColHead});
            this.listCatView.HideSelection = false;
            this.listCatView.Location = new System.Drawing.Point(12, 194);
            this.listCatView.Name = "listCatView";
            this.listCatView.Size = new System.Drawing.Size(455, 397);
            this.listCatView.TabIndex = 9;
            this.listCatView.UseCompatibleStateImageBehavior = false;
            this.listCatView.View = System.Windows.Forms.View.Details;
            this.listCatView.SelectedIndexChanged += new System.EventHandler(this.listCatView_SelectedIndexChanged);
            // 
            // prodIdColHead
            // 
            this.prodIdColHead.Text = "ID";
            // 
            // prodNameColHead
            // 
            this.prodNameColHead.Text = "Name";
            this.prodNameColHead.Width = 152;
            // 
            // prodDescColHead
            // 
            this.prodDescColHead.Text = "Description";
            this.prodDescColHead.Width = 151;
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeCategoryButton.Location = new System.Drawing.Point(885, 352);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.removeCategoryButton.TabIndex = 24;
            this.removeCategoryButton.Text = "REMOVE";
            this.removeCategoryButton.UseVisualStyleBackColor = true;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addCategoryButton.Location = new System.Drawing.Point(703, 352);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.addCategoryButton.TabIndex = 23;
            this.addCategoryButton.Text = "ADD";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // productDescrLabel
            // 
            this.productDescrLabel.AutoSize = true;
            this.productDescrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDescrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productDescrLabel.Location = new System.Drawing.Point(473, 219);
            this.productDescrLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productDescrLabel.Name = "productDescrLabel";
            this.productDescrLabel.Size = new System.Drawing.Size(99, 23);
            this.productDescrLabel.TabIndex = 21;
            this.productDescrLabel.Text = "Description:";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryNameLabel.Location = new System.Drawing.Point(473, 191);
            this.categoryNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(133, 23);
            this.categoryNameLabel.TabIndex = 20;
            this.categoryNameLabel.Text = "Category Name:";
            // 
            // prodCatDesTextBox
            // 
            this.prodCatDesTextBox.Location = new System.Drawing.Point(678, 222);
            this.prodCatDesTextBox.Name = "prodCatDesTextBox";
            this.prodCatDesTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatDesTextBox.TabIndex = 18;
            // 
            // prodCatTextBox
            // 
            this.prodCatTextBox.Location = new System.Drawing.Point(678, 194);
            this.prodCatTextBox.Name = "prodCatTextBox";
            this.prodCatTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCatTextBox.TabIndex = 17;
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
            this.menuStrip1.TabIndex = 27;
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
            // updateCategoryButton
            // 
            this.updateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCategoryButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateCategoryButton.Location = new System.Drawing.Point(794, 352);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(85, 55);
            this.updateCategoryButton.TabIndex = 28;
            this.updateCategoryButton.Text = "UPDATE";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dishCategoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(164, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 205);
            this.dataGridView1.TabIndex = 29;
            //
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateCategoryButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.productDescrLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.prodCatDesTextBox);
            this.Controls.Add(this.prodCatTextBox);
            this.Controls.Add(this.listCatLabel);
            this.Controls.Add(this.listCatView);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddCategoryForm";
            this.Text = "POS - Add Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategoryForm_FormClosing);
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label listCatLabel;
        private System.Windows.Forms.ListView listCatView;
        private System.Windows.Forms.ColumnHeader prodIdColHead;
        private System.Windows.Forms.ColumnHeader prodNameColHead;
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label productDescrLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox prodCatDesTextBox;
        private System.Windows.Forms.TextBox prodCatTextBox;
        private System.Windows.Forms.ColumnHeader prodDescColHead;
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
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private DishCategoryDataSet dishCategoryDataSet;
        private System.Windows.Forms.BindingSource dishCategoryBindingSource;
        //private DishCategoryDataSetTableAdapters.DishCategoryTableAdapter dishCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}