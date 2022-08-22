
namespace PointOfSaleApp.Forms
{
    partial class AddDishForm
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
            this.removeDishButton = new System.Windows.Forms.Button();
            this.addDishButton = new System.Windows.Forms.Button();
            this.dishCategoryLabel = new System.Windows.Forms.Label();
            this.dishFullNameLabel = new System.Windows.Forms.Label();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.dishFullNameTextBox = new System.Windows.Forms.TextBox();
            this.dishNameTextBox = new System.Windows.Forms.TextBox();
            this.listDishLabel = new System.Windows.Forms.Label();
            this.dishPriceLabel = new System.Windows.Forms.Label();
            this.dishDescLabel = new System.Windows.Forms.Label();
            this.dishGridView = new System.Windows.Forms.DataGridView();
            this.dishDescTextBox = new System.Windows.Forms.TextBox();
            this.updateDishButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.dishIDLabel = new System.Windows.Forms.Label();
            this.dishIDTextBox = new System.Windows.Forms.TextBox();
            this.dishCatListView = new System.Windows.Forms.ListView();
            this.dishIDCatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishNameCatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishCatSelectListView = new System.Windows.Forms.ListView();
            this.dishSelectIDCatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishSelectNameCatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearDishButton = new System.Windows.Forms.Button();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.userLogoControl1 = new PointOfSaleApp.UserLogoControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dishGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeDishButton
            // 
            this.removeDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeDishButton.Location = new System.Drawing.Point(885, 536);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(85, 55);
            this.removeDishButton.TabIndex = 34;
            this.removeDishButton.Text = "REMOVE";
            this.removeDishButton.UseVisualStyleBackColor = true;
            this.removeDishButton.Click += new System.EventHandler(this.removeDishButton_Click);
            // 
            // addDishButton
            // 
            this.addDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addDishButton.Location = new System.Drawing.Point(703, 536);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(85, 55);
            this.addDishButton.TabIndex = 33;
            this.addDishButton.Text = "ADD";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // dishCategoryLabel
            // 
            this.dishCategoryLabel.AutoSize = true;
            this.dishCategoryLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishCategoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishCategoryLabel.Location = new System.Drawing.Point(484, 281);
            this.dishCategoryLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishCategoryLabel.Name = "dishCategoryLabel";
            this.dishCategoryLabel.Size = new System.Drawing.Size(82, 23);
            this.dishCategoryLabel.TabIndex = 32;
            this.dishCategoryLabel.Text = "Category:";
            // 
            // dishFullNameLabel
            // 
            this.dishFullNameLabel.AutoSize = true;
            this.dishFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishFullNameLabel.Location = new System.Drawing.Point(484, 256);
            this.dishFullNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishFullNameLabel.Name = "dishFullNameLabel";
            this.dishFullNameLabel.Size = new System.Drawing.Size(129, 23);
            this.dishFullNameLabel.TabIndex = 31;
            this.dishFullNameLabel.Text = "Dish Full Name:";
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishNameLabel.Location = new System.Drawing.Point(484, 230);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(98, 23);
            this.dishNameLabel.TabIndex = 30;
            this.dishNameLabel.Text = "Dish Name:";
            // 
            // dishFullNameTextBox
            // 
            this.dishFullNameTextBox.Location = new System.Drawing.Point(626, 259);
            this.dishFullNameTextBox.Name = "dishFullNameTextBox";
            this.dishFullNameTextBox.Size = new System.Drawing.Size(344, 22);
            this.dishFullNameTextBox.TabIndex = 28;
            // 
            // dishNameTextBox
            // 
            this.dishNameTextBox.Location = new System.Drawing.Point(626, 231);
            this.dishNameTextBox.Name = "dishNameTextBox";
            this.dishNameTextBox.Size = new System.Drawing.Size(344, 22);
            this.dishNameTextBox.TabIndex = 27;
            // 
            // listDishLabel
            // 
            this.listDishLabel.AutoSize = true;
            this.listDishLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listDishLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listDishLabel.Location = new System.Drawing.Point(12, 200);
            this.listDishLabel.Name = "listDishLabel";
            this.listDishLabel.Size = new System.Drawing.Size(100, 30);
            this.listDishLabel.TabIndex = 26;
            this.listDishLabel.Text = "Dish List";
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishPriceLabel.Location = new System.Drawing.Point(493, 465);
            this.dishPriceLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(51, 23);
            this.dishPriceLabel.TabIndex = 36;
            this.dishPriceLabel.Text = "Price:";
            // 
            // dishDescLabel
            // 
            this.dishDescLabel.AutoSize = true;
            this.dishDescLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishDescLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishDescLabel.Location = new System.Drawing.Point(493, 495);
            this.dishDescLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishDescLabel.Name = "dishDescLabel";
            this.dishDescLabel.Size = new System.Drawing.Size(99, 23);
            this.dishDescLabel.TabIndex = 38;
            this.dishDescLabel.Text = "Description:";
            // 
            // dishGridView
            // 
            this.dishGridView.AllowUserToAddRows = false;
            this.dishGridView.AllowUserToDeleteRows = false;
            this.dishGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dishGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishGridView.Location = new System.Drawing.Point(17, 233);
            this.dishGridView.MultiSelect = false;
            this.dishGridView.Name = "dishGridView";
            this.dishGridView.ReadOnly = true;
            this.dishGridView.RowHeadersWidth = 51;
            this.dishGridView.RowTemplate.Height = 24;
            this.dishGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishGridView.Size = new System.Drawing.Size(470, 358);
            this.dishGridView.TabIndex = 41;
            this.dishGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dishDescTextBox
            // 
            this.dishDescTextBox.Location = new System.Drawing.Point(626, 496);
            this.dishDescTextBox.Name = "dishDescTextBox";
            this.dishDescTextBox.Size = new System.Drawing.Size(344, 22);
            this.dishDescTextBox.TabIndex = 43;
            // 
            // updateDishButton
            // 
            this.updateDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateDishButton.Location = new System.Drawing.Point(794, 536);
            this.updateDishButton.Name = "updateDishButton";
            this.updateDishButton.Size = new System.Drawing.Size(85, 55);
            this.updateDishButton.TabIndex = 46;
            this.updateDishButton.Text = "UPDATE";
            this.updateDishButton.UseVisualStyleBackColor = true;
            this.updateDishButton.Click += new System.EventHandler(this.updateDishButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rightButton.Location = new System.Drawing.Point(779, 329);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(38, 42);
            this.rightButton.TabIndex = 48;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.leftButton.Location = new System.Drawing.Point(779, 376);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(38, 42);
            this.leftButton.TabIndex = 49;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // dishIDLabel
            // 
            this.dishIDLabel.AutoSize = true;
            this.dishIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishIDLabel.Location = new System.Drawing.Point(484, 200);
            this.dishIDLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishIDLabel.Name = "dishIDLabel";
            this.dishIDLabel.Size = new System.Drawing.Size(68, 23);
            this.dishIDLabel.TabIndex = 51;
            this.dishIDLabel.Text = "Dish ID:";
            // 
            // dishIDTextBox
            // 
            this.dishIDTextBox.Enabled = false;
            this.dishIDTextBox.Location = new System.Drawing.Point(626, 203);
            this.dishIDTextBox.Name = "dishIDTextBox";
            this.dishIDTextBox.Size = new System.Drawing.Size(344, 22);
            this.dishIDTextBox.TabIndex = 50;
            this.dishIDTextBox.Text = "0";
            // 
            // dishCatListView
            // 
            this.dishCatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dishIDCatColHead,
            this.dishNameCatColHead});
            this.dishCatListView.FullRowSelect = true;
            this.dishCatListView.HideSelection = false;
            this.dishCatListView.Location = new System.Drawing.Point(626, 287);
            this.dishCatListView.Name = "dishCatListView";
            this.dishCatListView.Size = new System.Drawing.Size(147, 175);
            this.dishCatListView.TabIndex = 52;
            this.dishCatListView.UseCompatibleStateImageBehavior = false;
            this.dishCatListView.View = System.Windows.Forms.View.Details;
            // 
            // dishIDCatColHead
            // 
            this.dishIDCatColHead.Text = "ID";
            this.dishIDCatColHead.Width = 25;
            // 
            // dishNameCatColHead
            // 
            this.dishNameCatColHead.Text = "Name";
            // 
            // dishCatSelectListView
            // 
            this.dishCatSelectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dishSelectIDCatColHead,
            this.dishSelectNameCatColHead});
            this.dishCatSelectListView.FullRowSelect = true;
            this.dishCatSelectListView.HideSelection = false;
            this.dishCatSelectListView.Location = new System.Drawing.Point(823, 287);
            this.dishCatSelectListView.Name = "dishCatSelectListView";
            this.dishCatSelectListView.Size = new System.Drawing.Size(147, 175);
            this.dishCatSelectListView.TabIndex = 53;
            this.dishCatSelectListView.UseCompatibleStateImageBehavior = false;
            this.dishCatSelectListView.View = System.Windows.Forms.View.Details;
            // 
            // dishSelectIDCatColHead
            // 
            this.dishSelectIDCatColHead.Text = "ID";
            this.dishSelectIDCatColHead.Width = 27;
            // 
            // dishSelectNameCatColHead
            // 
            this.dishSelectNameCatColHead.Text = "Name";
            // 
            // clearDishButton
            // 
            this.clearDishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDishButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clearDishButton.Location = new System.Drawing.Point(537, 536);
            this.clearDishButton.Name = "clearDishButton";
            this.clearDishButton.Size = new System.Drawing.Size(85, 55);
            this.clearDishButton.TabIndex = 54;
            this.clearDishButton.Text = "CLEAR";
            this.clearDishButton.UseVisualStyleBackColor = true;
            this.clearDishButton.Click += new System.EventHandler(this.clearDishButton_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(626, 468);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(344, 22);
            this.priceNumericUpDown.TabIndex = 55;
            this.priceNumericUpDown.Leave += new System.EventHandler(this.priceNumericUpDown_Leave);
            // 
            // userLogoControl1
            // 
            this.userLogoControl1.Location = new System.Drawing.Point(0, 31);
            this.userLogoControl1.Name = "userLogoControl1";
            this.userLogoControl1.Size = new System.Drawing.Size(982, 157);
            this.userLogoControl1.TabIndex = 56;
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
            this.menuStrip1.TabIndex = 57;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userLogoControl1);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.clearDishButton);
            this.Controls.Add(this.dishCatSelectListView);
            this.Controls.Add(this.dishCatListView);
            this.Controls.Add(this.dishIDLabel);
            this.Controls.Add(this.dishIDTextBox);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.updateDishButton);
            this.Controls.Add(this.dishDescTextBox);
            this.Controls.Add(this.dishGridView);
            this.Controls.Add(this.dishDescLabel);
            this.Controls.Add(this.dishPriceLabel);
            this.Controls.Add(this.removeDishButton);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.dishCategoryLabel);
            this.Controls.Add(this.dishFullNameLabel);
            this.Controls.Add(this.dishNameLabel);
            this.Controls.Add(this.dishFullNameTextBox);
            this.Controls.Add(this.dishNameTextBox);
            this.Controls.Add(this.listDishLabel);
            this.Name = "AddDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Add or Edit Dish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDishForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeDishButton;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Label dishCategoryLabel;
        private System.Windows.Forms.Label dishFullNameLabel;
        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.TextBox dishFullNameTextBox;
        private System.Windows.Forms.TextBox dishNameTextBox;
        private System.Windows.Forms.Label listDishLabel;
        private System.Windows.Forms.Label dishPriceLabel;
        private System.Windows.Forms.Label dishDescLabel;
        private System.Windows.Forms.DataGridView dishGridView;
        private System.Windows.Forms.TextBox dishDescTextBox;
        private System.Windows.Forms.Button updateDishButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label dishIDLabel;
        private System.Windows.Forms.TextBox dishIDTextBox;
        private System.Windows.Forms.ListView dishCatListView;
        private System.Windows.Forms.ListView dishCatSelectListView;
        private System.Windows.Forms.ColumnHeader dishIDCatColHead;
        private System.Windows.Forms.ColumnHeader dishNameCatColHead;
        private System.Windows.Forms.ColumnHeader dishSelectIDCatColHead;
        private System.Windows.Forms.ColumnHeader dishSelectNameCatColHead;
        private System.Windows.Forms.Button clearDishButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private UserLogoControl userLogoControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}