
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.dishCategoryLabel = new System.Windows.Forms.Label();
            this.dishFullNameLabel = new System.Windows.Forms.Label();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.prodCatComboBox = new System.Windows.Forms.ComboBox();
            this.prodQuantityTextBox = new System.Windows.Forms.TextBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.listDishLabel = new System.Windows.Forms.Label();
            this.listDishView = new System.Windows.Forms.ListView();
            this.prodIdColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNameColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodQuantColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dishPriceLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dishDescLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(958, 136);
            this.mainPanel.TabIndex = 9;
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
            // removeProductButton
            // 
            this.removeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeProductButton.Location = new System.Drawing.Point(794, 352);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(85, 55);
            this.removeProductButton.TabIndex = 34;
            this.removeProductButton.Text = "REMOVE";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProductButton.Location = new System.Drawing.Point(885, 352);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(85, 55);
            this.addProductButton.TabIndex = 33;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // dishCategoryLabel
            // 
            this.dishCategoryLabel.AutoSize = true;
            this.dishCategoryLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishCategoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishCategoryLabel.Location = new System.Drawing.Point(493, 251);
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
            this.dishFullNameLabel.Location = new System.Drawing.Point(493, 221);
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
            this.dishNameLabel.Location = new System.Drawing.Point(493, 193);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(98, 23);
            this.dishNameLabel.TabIndex = 30;
            this.dishNameLabel.Text = "Dish Name:";
            // 
            // prodCatComboBox
            // 
            this.prodCatComboBox.FormattingEnabled = true;
            this.prodCatComboBox.Location = new System.Drawing.Point(678, 250);
            this.prodCatComboBox.Name = "prodCatComboBox";
            this.prodCatComboBox.Size = new System.Drawing.Size(292, 24);
            this.prodCatComboBox.TabIndex = 29;
            // 
            // prodQuantityTextBox
            // 
            this.prodQuantityTextBox.Location = new System.Drawing.Point(678, 222);
            this.prodQuantityTextBox.Name = "prodQuantityTextBox";
            this.prodQuantityTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodQuantityTextBox.TabIndex = 28;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Location = new System.Drawing.Point(678, 194);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodNameTextBox.TabIndex = 27;
            // 
            // listDishLabel
            // 
            this.listDishLabel.AutoSize = true;
            this.listDishLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listDishLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listDishLabel.Location = new System.Drawing.Point(12, 161);
            this.listDishLabel.Name = "listDishLabel";
            this.listDishLabel.Size = new System.Drawing.Size(100, 30);
            this.listDishLabel.TabIndex = 26;
            this.listDishLabel.Text = "Dish List";
            // 
            // listDishView
            // 
            this.listDishView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodIdColHead,
            this.prodNameColHead,
            this.prodQuantColHead});
            this.listDishView.HideSelection = false;
            this.listDishView.Location = new System.Drawing.Point(12, 194);
            this.listDishView.Name = "listDishView";
            this.listDishView.Size = new System.Drawing.Size(412, 397);
            this.listDishView.TabIndex = 25;
            this.listDishView.UseCompatibleStateImageBehavior = false;
            this.listDishView.View = System.Windows.Forms.View.Details;
            // 
            // prodIdColHead
            // 
            this.prodIdColHead.Text = "ID";
            // 
            // prodNameColHead
            // 
            this.prodNameColHead.Text = "Name";
            this.prodNameColHead.Width = 261;
            // 
            // prodQuantColHead
            // 
            this.prodQuantColHead.Text = "Quantity";
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishPriceLabel.Location = new System.Drawing.Point(493, 281);
            this.dishPriceLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(51, 23);
            this.dishPriceLabel.TabIndex = 36;
            this.dishPriceLabel.Text = "Price:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(678, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 35;
            // 
            // dishDescLabel
            // 
            this.dishDescLabel.AutoSize = true;
            this.dishDescLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishDescLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishDescLabel.Location = new System.Drawing.Point(493, 311);
            this.dishDescLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishDescLabel.Name = "dishDescLabel";
            this.dishDescLabel.Size = new System.Drawing.Size(99, 23);
            this.dishDescLabel.TabIndex = 38;
            this.dishDescLabel.Text = "Description:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(678, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 24);
            this.comboBox2.TabIndex = 37;
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.dishDescLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dishPriceLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dishCategoryLabel);
            this.Controls.Add(this.dishFullNameLabel);
            this.Controls.Add(this.dishNameLabel);
            this.Controls.Add(this.prodCatComboBox);
            this.Controls.Add(this.prodQuantityTextBox);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(this.listDishLabel);
            this.Controls.Add(this.listDishView);
            this.Controls.Add(this.mainPanel);
            this.Name = "AddDishForm";
            this.Text = "AddDishForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label dishCategoryLabel;
        private System.Windows.Forms.Label dishFullNameLabel;
        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.ComboBox prodCatComboBox;
        private System.Windows.Forms.TextBox prodQuantityTextBox;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.Label listDishLabel;
        private System.Windows.Forms.ListView listDishView;
        private System.Windows.Forms.ColumnHeader prodIdColHead;
        private System.Windows.Forms.ColumnHeader prodNameColHead;
        private System.Windows.Forms.ColumnHeader prodQuantColHead;
        private System.Windows.Forms.Label dishPriceLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dishDescLabel;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}