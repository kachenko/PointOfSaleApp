
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.dishButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryButton = new System.Windows.Forms.Button();
            this.myAccountButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.tablesButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.paymentMethodButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newOrderButton.Location = new System.Drawing.Point(24, 194);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(183, 113);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "NEW ORDER";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usersButton.Location = new System.Drawing.Point(524, 313);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(183, 113);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "USERS";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myOrdersButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.myOrdersButton.Location = new System.Drawing.Point(275, 194);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(183, 113);
            this.myOrdersButton.TabIndex = 1;
            this.myOrdersButton.Text = "ALL ORDERS";
            this.myOrdersButton.UseVisualStyleBackColor = true;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.menuButton.Location = new System.Drawing.Point(524, 194);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(183, 113);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // dishButton
            // 
            this.dishButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishButton.Location = new System.Drawing.Point(24, 313);
            this.dishButton.Name = "dishButton";
            this.dishButton.Size = new System.Drawing.Size(183, 113);
            this.dishButton.TabIndex = 4;
            this.dishButton.Text = "DISHES";
            this.dishButton.UseVisualStyleBackColor = true;
            this.dishButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 26;
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
            // categoryButton
            // 
            this.categoryButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryButton.Location = new System.Drawing.Point(275, 313);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(183, 113);
            this.categoryButton.TabIndex = 5;
            this.categoryButton.Text = "CATEGORIES";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // myAccountButton
            // 
            this.myAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myAccountButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAccountButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.myAccountButton.Location = new System.Drawing.Point(769, 194);
            this.myAccountButton.Name = "myAccountButton";
            this.myAccountButton.Size = new System.Drawing.Size(183, 113);
            this.myAccountButton.TabIndex = 3;
            this.myAccountButton.Text = "MY ACCOUNT";
            this.myAccountButton.UseVisualStyleBackColor = true;
            this.myAccountButton.Click += new System.EventHandler(this.myAccountButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.reportsButton.Location = new System.Drawing.Point(769, 313);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(183, 113);
            this.reportsButton.TabIndex = 7;
            this.reportsButton.Text = "REPORTS";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // tablesButton
            // 
            this.tablesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tablesButton.Location = new System.Drawing.Point(24, 432);
            this.tablesButton.Name = "tablesButton";
            this.tablesButton.Size = new System.Drawing.Size(183, 113);
            this.tablesButton.TabIndex = 8;
            this.tablesButton.Text = "TABLES";
            this.tablesButton.UseVisualStyleBackColor = true;
            this.tablesButton.Click += new System.EventHandler(this.tablesButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(203)))), ((int)(((byte)(170)))));
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.loginLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 157);
            this.mainPanel.TabIndex = 30;
            // 
            // positLabel
            // 
            this.positLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.positLabel.AutoSize = true;
            this.positLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.positLabel.Location = new System.Drawing.Point(848, 125);
            this.positLabel.Name = "positLabel";
            this.positLabel.Size = new System.Drawing.Size(70, 23);
            this.positLabel.TabIndex = 71;
            this.positLabel.Text = "Position";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginLabel.Location = new System.Drawing.Point(651, 118);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(182, 32);
            this.loginLabel.TabIndex = 70;
            this.loginLabel.Text = "Name Surname";
            // 
            // paymentMethodButton
            // 
            this.paymentMethodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentMethodButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.paymentMethodButton.Location = new System.Drawing.Point(275, 432);
            this.paymentMethodButton.Name = "paymentMethodButton";
            this.paymentMethodButton.Size = new System.Drawing.Size(183, 113);
            this.paymentMethodButton.TabIndex = 9;
            this.paymentMethodButton.Text = "PAYMENT METHODS";
            this.paymentMethodButton.UseVisualStyleBackColor = true;
            this.paymentMethodButton.Click += new System.EventHandler(this.paymentMethodButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSaleApp.Properties.Resources.EEE1234LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(176, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSaleApp.Properties.Resources._1324_2___1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 557);
            this.Controls.Add(this.paymentMethodButton);
            this.Controls.Add(this.tablesButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.myAccountButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dishButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.myOrdersButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.newOrderButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSi - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button myOrdersButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button dishButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button myAccountButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button tablesButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label positLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button paymentMethodButton;
    }
}