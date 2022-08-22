
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.categoryButtonPanel = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.addDishButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogoControl1 = new PointOfSaleApp.UserLogoControl();
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
            this.dishMenuDataGridView.Location = new System.Drawing.Point(357, 224);
            this.dishMenuDataGridView.MultiSelect = false;
            this.dishMenuDataGridView.Name = "dishMenuDataGridView";
            this.dishMenuDataGridView.ReadOnly = true;
            this.dishMenuDataGridView.RowHeadersWidth = 51;
            this.dishMenuDataGridView.RowTemplate.Height = 24;
            this.dishMenuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishMenuDataGridView.Size = new System.Drawing.Size(700, 264);
            this.dishMenuDataGridView.TabIndex = 0;
            this.dishMenuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishMenuDataGridView_CellClick);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.menuLabel.Location = new System.Drawing.Point(12, 130);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(101, 38);
            this.menuLabel.TabIndex = 42;
            this.menuLabel.Text = "MENU";
            // 
            // categoryButtonPanel
            // 
            this.categoryButtonPanel.Location = new System.Drawing.Point(12, 194);
            this.categoryButtonPanel.Name = "categoryButtonPanel";
            this.categoryButtonPanel.Size = new System.Drawing.Size(327, 317);
            this.categoryButtonPanel.TabIndex = 43;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryLabel.Location = new System.Drawing.Point(352, 191);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(227, 32);
            this.categoryLabel.TabIndex = 44;
            this.categoryLabel.Text = "Selected Category:";
            // 
            // addDishButton
            // 
            this.addDishButton.BackColor = System.Drawing.Color.Tomato;
            this.addDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDishButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addDishButton.Location = new System.Drawing.Point(357, 494);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(700, 55);
            this.addDishButton.TabIndex = 45;
            this.addDishButton.Text = "MODIFY DISH";
            this.addDishButton.UseVisualStyleBackColor = false;
            this.addDishButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 30);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userLogoControl1
            // 
            this.userLogoControl1.Location = new System.Drawing.Point(0, 31);
            this.userLogoControl1.Name = "userLogoControl1";
            this.userLogoControl1.Size = new System.Drawing.Size(1069, 157);
            this.userLogoControl1.TabIndex = 59;
            // 
            // DishesMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1069, 562);
            this.Controls.Add(this.userLogoControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryButtonPanel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.dishMenuDataGridView);
            this.Name = "DishesMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel categoryButtonPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private UserLogoControl userLogoControl1;
    }
}