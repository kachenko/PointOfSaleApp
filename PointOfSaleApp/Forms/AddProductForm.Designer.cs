
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
            this.prodListView = new System.Windows.Forms.ListView();
            this.prodIdColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodCodeColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNameColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodCategColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodUnitColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prodListView
            // 
            this.prodListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodIdColHead,
            this.prodCodeColHead,
            this.prodNameColHead,
            this.prodCategColHead,
            this.prodUnitColHead});
            this.prodListView.HideSelection = false;
            this.prodListView.Location = new System.Drawing.Point(12, 194);
            this.prodListView.Name = "prodListView";
            this.prodListView.Size = new System.Drawing.Size(475, 397);
            this.prodListView.TabIndex = 0;
            this.prodListView.UseCompatibleStateImageBehavior = false;
            this.prodListView.View = System.Windows.Forms.View.Details;
            // 
            // prodIdColHead
            // 
            this.prodIdColHead.Text = "ID";
            // 
            // prodCodeColHead
            // 
            this.prodCodeColHead.DisplayIndex = 3;
            this.prodCodeColHead.Text = "Code";
            this.prodCodeColHead.Width = 82;
            // 
            // prodNameColHead
            // 
            this.prodNameColHead.DisplayIndex = 1;
            this.prodNameColHead.Text = "Name";
            this.prodNameColHead.Width = 90;
            // 
            // prodCategColHead
            // 
            this.prodCategColHead.DisplayIndex = 2;
            this.prodCategColHead.Text = "Category";
            this.prodCategColHead.Width = 87;
            // 
            // prodUnitColHead
            // 
            this.prodUnitColHead.Text = "Unit";
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
            this.prodNameTextBox.Location = new System.Drawing.Point(678, 215);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodNameTextBox.TabIndex = 9;
            // 
            // prodCodeTextBox
            // 
            this.prodCodeTextBox.Location = new System.Drawing.Point(678, 243);
            this.prodCodeTextBox.Name = "prodCodeTextBox";
            this.prodCodeTextBox.Size = new System.Drawing.Size(292, 22);
            this.prodCodeTextBox.TabIndex = 10;
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
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCodeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productCodeLabel.Location = new System.Drawing.Point(493, 242);
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
            // productUnitLabel
            // 
            this.productUnitLabel.AutoSize = true;
            this.productUnitLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productUnitLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productUnitLabel.Location = new System.Drawing.Point(493, 300);
            this.productUnitLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.productUnitLabel.Name = "productUnitLabel";
            this.productUnitLabel.Size = new System.Drawing.Size(45, 23);
            this.productUnitLabel.TabIndex = 18;
            this.productUnitLabel.Text = "Unit:";
            // 
            // prodUnitComboBox
            // 
            this.prodUnitComboBox.FormattingEnabled = true;
            this.prodUnitComboBox.Location = new System.Drawing.Point(678, 301);
            this.prodUnitComboBox.Name = "prodUnitComboBox";
            this.prodUnitComboBox.Size = new System.Drawing.Size(292, 24);
            this.prodUnitComboBox.TabIndex = 19;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
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
            this.Controls.Add(this.prodListView);
            this.Name = "AddProductForm";
            this.Text = "POS - Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prodListView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label listProdLabel;
        private System.Windows.Forms.ColumnHeader prodIdColHead;
        private System.Windows.Forms.ColumnHeader prodNameColHead;
        private System.Windows.Forms.ColumnHeader prodCategColHead;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox prodCodeTextBox;
        private System.Windows.Forms.ComboBox prodCatComboBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.ColumnHeader prodCodeColHead;
        private System.Windows.Forms.ColumnHeader prodUnitColHead;
        private System.Windows.Forms.Label productUnitLabel;
        private System.Windows.Forms.ComboBox prodUnitComboBox;
    }
}