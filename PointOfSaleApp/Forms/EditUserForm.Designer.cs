
namespace PointOfSaleApp.Forms
{
    partial class EditUserForm
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
            this.changeImageButton = new System.Windows.Forms.Button();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userAddressLabel = new System.Windows.Forms.Label();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userPhoneTextBox = new System.Windows.Forms.TextBox();
            this.userAddressTextBox = new System.Windows.Forms.TextBox();
            this.userFullNameTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.changePasswdButton = new System.Windows.Forms.Button();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(567, 28);
            this.menuStrip1.TabIndex = 99;
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
            // changeImageButton
            // 
            this.changeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImageButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeImageButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeImageButton.Location = new System.Drawing.Point(12, 204);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(137, 55);
            this.changeImageButton.TabIndex = 98;
            this.changeImageButton.Text = "CHANGE IMAGE";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // saveUserButton
            // 
            this.saveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveUserButton.Location = new System.Drawing.Point(469, 365);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(85, 55);
            this.saveUserButton.TabIndex = 97;
            this.saveUserButton.Text = "SAVE";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userRoleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userRoleLabel.Location = new System.Drawing.Point(170, 307);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(56, 28);
            this.userRoleLabel.TabIndex = 95;
            this.userRoleLabel.Text = "Role:";
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userPhoneLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPhoneLabel.Location = new System.Drawing.Point(170, 279);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(74, 28);
            this.userPhoneLabel.TabIndex = 94;
            this.userPhoneLabel.Text = "Phone:";
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userAddressLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userAddressLabel.Location = new System.Drawing.Point(170, 194);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(89, 28);
            this.userAddressLabel.TabIndex = 93;
            this.userAddressLabel.Text = "Address:";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userFullNameLabel.Location = new System.Drawing.Point(169, 77);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(109, 28);
            this.userFullNameLabel.TabIndex = 92;
            this.userFullNameLabel.Text = "Full Name:";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userLoginLabel.Location = new System.Drawing.Point(169, 160);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(67, 28);
            this.userLoginLabel.TabIndex = 91;
            this.userLoginLabel.Text = "Login:";
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPictureBox.Image = global::PointOfSaleApp.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(12, 45);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(137, 153);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 90;
            this.userPictureBox.TabStop = false;
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Location = new System.Drawing.Point(307, 279);
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(248, 22);
            this.userPhoneTextBox.TabIndex = 88;
            // 
            // userAddressTextBox
            // 
            this.userAddressTextBox.Location = new System.Drawing.Point(307, 194);
            this.userAddressTextBox.Multiline = true;
            this.userAddressTextBox.Name = "userAddressTextBox";
            this.userAddressTextBox.Size = new System.Drawing.Size(248, 79);
            this.userAddressTextBox.TabIndex = 87;
            // 
            // userFullNameTextBox
            // 
            this.userFullNameTextBox.Location = new System.Drawing.Point(306, 77);
            this.userFullNameTextBox.Multiline = true;
            this.userFullNameTextBox.Name = "userFullNameTextBox";
            this.userFullNameTextBox.Size = new System.Drawing.Size(248, 83);
            this.userFullNameTextBox.TabIndex = 84;
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(306, 166);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(248, 22);
            this.userLoginTextBox.TabIndex = 85;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userLabel.Location = new System.Drawing.Point(170, 45);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 28);
            this.userLabel.TabIndex = 101;
            this.userLabel.Text = "ID:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Enabled = false;
            this.userIDTextBox.Location = new System.Drawing.Point(307, 45);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(127, 22);
            this.userIDTextBox.TabIndex = 100;
            // 
            // changePasswdButton
            // 
            this.changePasswdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswdButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswdButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changePasswdButton.Location = new System.Drawing.Point(12, 365);
            this.changePasswdButton.Name = "changePasswdButton";
            this.changePasswdButton.Size = new System.Drawing.Size(133, 55);
            this.changePasswdButton.TabIndex = 102;
            this.changePasswdButton.Text = "CHANGE PASSWORD";
            this.changePasswdButton.UseVisualStyleBackColor = true;
            this.changePasswdButton.Click += new System.EventHandler(this.changePasswdButton_Click);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(307, 311);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(249, 24);
            this.userRoleComboBox.TabIndex = 103;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(567, 433);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.changePasswdButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userPhoneLabel);
            this.Controls.Add(this.userAddressLabel);
            this.Controls.Add(this.userFullNameLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.userPhoneTextBox);
            this.Controls.Add(this.userAddressTextBox);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POSi - Edit User";
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
        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.Label userAddressLabel;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Button changePasswdButton;
        private System.Windows.Forms.ComboBox userRoleComboBox;
    }
}