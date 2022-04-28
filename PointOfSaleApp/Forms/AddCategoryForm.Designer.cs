
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.listCatLabel = new System.Windows.Forms.Label();
            this.listCatView = new System.Windows.Forms.ListView();
            this.prodIdColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNameColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productDescrLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.prodCatDesTextBox = new System.Windows.Forms.TextBox();
            this.prodCatTextBox = new System.Windows.Forms.TextBox();
            this.prodDescColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
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
            // removeProductButton
            // 
            this.removeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeProductButton.Location = new System.Drawing.Point(794, 352);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(85, 55);
            this.removeProductButton.TabIndex = 24;
            this.removeProductButton.Text = "REMOVE";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProductButton.Location = new System.Drawing.Point(885, 352);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(85, 55);
            this.addProductButton.TabIndex = 23;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
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
            // prodDescColHead
            // 
            this.prodDescColHead.Text = "Description";
            this.prodDescColHead.Width = 151;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.newOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.newOrderToolStripMenuItem.Text = "New Order";
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
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
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label productDescrLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox prodCatDesTextBox;
        private System.Windows.Forms.TextBox prodCatTextBox;
        private System.Windows.Forms.ColumnHeader prodDescColHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
    }
}