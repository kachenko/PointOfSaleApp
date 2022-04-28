
namespace PointOfSaleApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.newOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.MyOrdersButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.addProdButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newOrderButton.Location = new System.Drawing.Point(12, 67);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(155, 155);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "NEW ORDER";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 46);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.Location = new System.Drawing.Point(94, 12);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 46);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsersButton.Location = new System.Drawing.Point(412, 67);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(155, 155);
            this.UsersButton.TabIndex = 3;
            this.UsersButton.Text = "USERS";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // MyOrdersButton
            // 
            this.MyOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyOrdersButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyOrdersButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MyOrdersButton.Location = new System.Drawing.Point(212, 67);
            this.MyOrdersButton.Name = "MyOrdersButton";
            this.MyOrdersButton.Size = new System.Drawing.Size(155, 155);
            this.MyOrdersButton.TabIndex = 4;
            this.MyOrdersButton.Text = "MY ORDERS";
            this.MyOrdersButton.UseVisualStyleBackColor = true;
            // 
            // MenuButton
            // 
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuButton.Location = new System.Drawing.Point(615, 67);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(155, 155);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.Text = "MENU";
            this.MenuButton.UseVisualStyleBackColor = true;
            // 
            // addProdButton
            // 
            this.addProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProdButton.Location = new System.Drawing.Point(815, 67);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(155, 155);
            this.addProdButton.TabIndex = 6;
            this.addProdButton.Text = "ADD PRODUCT";
            this.addProdButton.UseVisualStyleBackColor = true;
            this.addProdButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryButton.Location = new System.Drawing.Point(12, 262);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(155, 155);
            this.categoryButton.TabIndex = 7;
            this.categoryButton.Text = "CATEGORY";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.addProdButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.MyOrdersButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newOrderButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button MyOrdersButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button addProdButton;
        private System.Windows.Forms.Button categoryButton;
    }
}