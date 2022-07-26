
namespace PointOfSaleApp.Forms
{
    partial class DishesMenuForm
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
            this.dishMenuDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLabel = new System.Windows.Forms.Label();
            this.categoryButtonPanel = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.addDishButton = new System.Windows.Forms.Button();
            this.editDishButton = new System.Windows.Forms.Button();
            this.removeDishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishMenuDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dishMenuDataGridView
            // 
            this.dishMenuDataGridView.AllowUserToAddRows = false;
            this.dishMenuDataGridView.AllowUserToDeleteRows = false;
            this.dishMenuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishMenuDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dishMenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishMenuDataGridView.Location = new System.Drawing.Point(357, 78);
            this.dishMenuDataGridView.MultiSelect = false;
            this.dishMenuDataGridView.Name = "dishMenuDataGridView";
            this.dishMenuDataGridView.ReadOnly = true;
            this.dishMenuDataGridView.RowHeadersWidth = 51;
            this.dishMenuDataGridView.RowTemplate.Height = 24;
            this.dishMenuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishMenuDataGridView.Size = new System.Drawing.Size(700, 489);
            this.dishMenuDataGridView.TabIndex = 0;
            this.dishMenuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishMenuDataGridView_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1069, 28);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.fileToolStripMenuItem.Text = "Session";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newSessionToolStripMenuItem.Text = "New Session";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.menuLabel.Location = new System.Drawing.Point(12, 37);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(101, 38);
            this.menuLabel.TabIndex = 42;
            this.menuLabel.Text = "MENU";
            // 
            // categoryButtonPanel
            // 
            this.categoryButtonPanel.Location = new System.Drawing.Point(12, 78);
            this.categoryButtonPanel.Name = "categoryButtonPanel";
            this.categoryButtonPanel.Size = new System.Drawing.Size(339, 317);
            this.categoryButtonPanel.TabIndex = 43;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryLabel.Location = new System.Drawing.Point(357, 44);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(190, 30);
            this.categoryLabel.TabIndex = 44;
            this.categoryLabel.Text = "Selected Category";
            // 
            // addDishButton
            // 
            this.addDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addDishButton.Location = new System.Drawing.Point(357, 576);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(85, 55);
            this.addDishButton.TabIndex = 45;
            this.addDishButton.Text = "ADD DISH";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // editDishButton
            // 
            this.editDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editDishButton.Location = new System.Drawing.Point(448, 576);
            this.editDishButton.Name = "editDishButton";
            this.editDishButton.Size = new System.Drawing.Size(85, 55);
            this.editDishButton.TabIndex = 46;
            this.editDishButton.Text = "EDIT DISH";
            this.editDishButton.UseVisualStyleBackColor = true;
            this.editDishButton.Click += new System.EventHandler(this.editDish_Click);
            // 
            // removeDishButton
            // 
            this.removeDishButton.BackColor = System.Drawing.Color.Tomato;
            this.removeDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDishButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.removeDishButton.Location = new System.Drawing.Point(539, 576);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(85, 55);
            this.removeDishButton.TabIndex = 47;
            this.removeDishButton.Text = "REMOVE DISH";
            this.removeDishButton.UseVisualStyleBackColor = false;
            this.removeDishButton.Click += new System.EventHandler(this.removeDish_Click);
            // 
            // DishesMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1069, 643);
            this.Controls.Add(this.removeDishButton);
            this.Controls.Add(this.editDishButton);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryButtonPanel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dishMenuDataGridView);
            this.Name = "DishesMenuForm";
            this.Text = "POSi - Restaurant Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DishesMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.DishesMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishMenuDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dishMenuDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel categoryButtonPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Button editDishButton;
        private System.Windows.Forms.Button removeDishButton;
    }
}