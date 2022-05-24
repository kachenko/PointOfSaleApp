
namespace PointOfSaleApp.Forms
{
    partial class MyAccountForm
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
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userIsActiveTextBox = new System.Windows.Forms.TextBox();
            this.userFullNameTextBox = new System.Windows.Forms.TextBox();
            this.userAddressTextBox = new System.Windows.Forms.TextBox();
            this.userPhoneTextBox = new System.Windows.Forms.TextBox();
            this.userRoleTextBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userIsActiveLabel = new System.Windows.Forms.Label();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.userAddressLabel = new System.Windows.Forms.Label();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
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
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newSessionToolStripMenuItem.Text = "New Session";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            // userIDTextBox
            // 
            this.userIDTextBox.Enabled = false;
            this.userIDTextBox.Location = new System.Drawing.Point(540, 158);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(66, 22);
            this.userIDTextBox.TabIndex = 42;
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Enabled = false;
            this.userLoginTextBox.Location = new System.Drawing.Point(540, 186);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(302, 22);
            this.userLoginTextBox.TabIndex = 43;
            // 
            // userIsActiveTextBox
            // 
            this.userIsActiveTextBox.Enabled = false;
            this.userIsActiveTextBox.Location = new System.Drawing.Point(540, 440);
            this.userIsActiveTextBox.Name = "userIsActiveTextBox";
            this.userIsActiveTextBox.Size = new System.Drawing.Size(151, 22);
            this.userIsActiveTextBox.TabIndex = 44;
            // 
            // userFullNameTextBox
            // 
            this.userFullNameTextBox.Enabled = false;
            this.userFullNameTextBox.Location = new System.Drawing.Point(540, 214);
            this.userFullNameTextBox.Multiline = true;
            this.userFullNameTextBox.Name = "userFullNameTextBox";
            this.userFullNameTextBox.Size = new System.Drawing.Size(302, 79);
            this.userFullNameTextBox.TabIndex = 45;
            // 
            // userAddressTextBox
            // 
            this.userAddressTextBox.Enabled = false;
            this.userAddressTextBox.Location = new System.Drawing.Point(540, 299);
            this.userAddressTextBox.Multiline = true;
            this.userAddressTextBox.Name = "userAddressTextBox";
            this.userAddressTextBox.Size = new System.Drawing.Size(302, 79);
            this.userAddressTextBox.TabIndex = 46;
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Enabled = false;
            this.userPhoneTextBox.Location = new System.Drawing.Point(540, 384);
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(302, 22);
            this.userPhoneTextBox.TabIndex = 47;
            // 
            // userRoleTextBox
            // 
            this.userRoleTextBox.Enabled = false;
            this.userRoleTextBox.Location = new System.Drawing.Point(540, 412);
            this.userRoleTextBox.Name = "userRoleTextBox";
            this.userRoleTextBox.Size = new System.Drawing.Size(302, 22);
            this.userRoleTextBox.TabIndex = 48;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userIDLabel.Location = new System.Drawing.Point(403, 158);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(35, 28);
            this.userIDLabel.TabIndex = 50;
            this.userIDLabel.Text = "ID:";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userLoginLabel.Location = new System.Drawing.Point(403, 186);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(67, 28);
            this.userLoginLabel.TabIndex = 51;
            this.userLoginLabel.Text = "Login:";
            // 
            // userIsActiveLabel
            // 
            this.userIsActiveLabel.AutoSize = true;
            this.userIsActiveLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userIsActiveLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userIsActiveLabel.Location = new System.Drawing.Point(403, 440);
            this.userIsActiveLabel.Name = "userIsActiveLabel";
            this.userIsActiveLabel.Size = new System.Drawing.Size(92, 28);
            this.userIsActiveLabel.TabIndex = 52;
            this.userIsActiveLabel.Text = "Is Active:";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userFullNameLabel.Location = new System.Drawing.Point(403, 214);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(109, 28);
            this.userFullNameLabel.TabIndex = 53;
            this.userFullNameLabel.Text = "Full Name:";
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userAddressLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userAddressLabel.Location = new System.Drawing.Point(403, 299);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(89, 28);
            this.userAddressLabel.TabIndex = 54;
            this.userAddressLabel.Text = "Address:";
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userPhoneLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPhoneLabel.Location = new System.Drawing.Point(403, 384);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(74, 28);
            this.userPhoneLabel.TabIndex = 55;
            this.userPhoneLabel.Text = "Phone:";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userRoleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userRoleLabel.Location = new System.Drawing.Point(403, 412);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(56, 28);
            this.userRoleLabel.TabIndex = 56;
            this.userRoleLabel.Text = "Role:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameLabel.Location = new System.Drawing.Point(277, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(182, 32);
            this.nameLabel.TabIndex = 57;
            this.nameLabel.Text = "Name Surname";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Enabled = false;
            this.saveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveUserButton.Location = new System.Drawing.Point(498, 499);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(85, 55);
            this.saveUserButton.TabIndex = 60;
            this.saveUserButton.Text = "SAVE";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editUserButton.Location = new System.Drawing.Point(407, 499);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(85, 55);
            this.editUserButton.TabIndex = 59;
            this.editUserButton.Text = "EDIT";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // changeImageButton
            // 
            this.changeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImageButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeImageButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeImageButton.Location = new System.Drawing.Point(69, 295);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(130, 55);
            this.changeImageButton.TabIndex = 62;
            this.changeImageButton.Text = "CHANGE IMAGE";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPictureBox.Image = global::PointOfSaleApp.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(12, 39);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(250, 250);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 49;
            this.userPictureBox.TabStop = false;
            // 
            // MyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userPhoneLabel);
            this.Controls.Add(this.userAddressLabel);
            this.Controls.Add(this.userFullNameLabel);
            this.Controls.Add(this.userIsActiveLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.userRoleTextBox);
            this.Controls.Add(this.userPhoneTextBox);
            this.Controls.Add(this.userAddressTextBox);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(this.userIsActiveTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MyAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccountForm";
            this.Load += new System.EventHandler(this.MyAccountForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox userIsActiveTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.TextBox userRoleTextBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label userIsActiveLabel;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label userAddressLabel;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button changeImageButton;
    }
}