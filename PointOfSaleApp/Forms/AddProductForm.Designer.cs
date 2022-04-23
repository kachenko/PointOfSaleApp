
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
            this.listProdView = new System.Windows.Forms.ListView();
            this.prodIdColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNameColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodQuantColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.listProdLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.prodQuantityTextBox = new System.Windows.Forms.TextBox();
            this.prodCatComboBox = new System.Windows.Forms.ComboBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productQuantLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listProdView
            // 
            this.listProdView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodIdColHead,
            this.prodNameColHead,
            this.prodQuantColHead});
            this.listProdView.HideSelection = false;
            this.listProdView.Location = new System.Drawing.Point(12, 194);
            this.listProdView.Name = "listProdView";
            this.listProdView.Size = new System.Drawing.Size(412, 397);
            this.listProdView.TabIndex = 0;
            this.listProdView.UseCompatibleStateImageBehavior = false;
            this.listProdView.View = System.Windows.Forms.View.Details;
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
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
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
            // prodNameTextBox
            // 
            this.prodNameTextBox.Location = new System.Drawing.Point(678, 215);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodNameTextBox.TabIndex = 9;
            // 
            // prodQuantityTextBox
            // 
            this.prodQuantityTextBox.Location = new System.Drawing.Point(678, 243);
            this.prodQuantityTextBox.Name = "prodQuantityTextBox";
            this.prodQuantityTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodQuantityTextBox.TabIndex = 10;
            // 
            // prodCatComboBox
            // 
            this.prodCatComboBox.FormattingEnabled = true;
            this.prodCatComboBox.Location = new System.Drawing.Point(678, 271);
            this.prodCatComboBox.Name = "prodCatComboBox";
            this.prodCatComboBox.Size = new System.Drawing.Size(292, 24);
            this.prodCatComboBox.TabIndex = 11;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productNameLabel.Location = new System.Drawing.Point(493, 214);
            this.productNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(124, 23);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productQuantLabel
            // 
            this.productQuantLabel.AutoSize = true;
            this.productQuantLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productQuantLabel.Location = new System.Drawing.Point(493, 242);
            this.productQuantLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productQuantLabel.Name = "productQuantLabel";
            this.productQuantLabel.Size = new System.Drawing.Size(78, 23);
            this.productQuantLabel.TabIndex = 13;
            this.productQuantLabel.Text = "Quantity:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productCategoryLabel.Location = new System.Drawing.Point(493, 272);
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
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productQuantLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.prodCatComboBox);
            this.Controls.Add(this.prodQuantityTextBox);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(this.listProdLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.listProdView);
            this.Name = "AddProductForm";
            this.Text = "POS - Add Product";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listProdView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label listProdLabel;
        private System.Windows.Forms.ColumnHeader prodIdColHead;
        private System.Windows.Forms.ColumnHeader prodNameColHead;
        private System.Windows.Forms.ColumnHeader prodQuantColHead;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox prodQuantityTextBox;
        private System.Windows.Forms.ComboBox prodCatComboBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productQuantLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
    }
}