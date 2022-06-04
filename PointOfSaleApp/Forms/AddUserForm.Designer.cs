
namespace PointOfSaleApp.Forms
{
    partial class AddUserForm
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
            this.changeImageButton = new System.Windows.Forms.Button();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userAddressLabel = new System.Windows.Forms.Label();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userRoleTextBox = new System.Windows.Forms.TextBox();
            this.userPhoneTextBox = new System.Windows.Forms.TextBox();
            this.userAddressTextBox = new System.Windows.Forms.TextBox();
            this.userFullNameTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeImageButton
            // 
            this.changeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImageButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeImageButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeImageButton.Location = new System.Drawing.Point(12, 200);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(137, 55);
            this.changeImageButton.TabIndex = 81;
            this.changeImageButton.Text = "CHANGE IMAGE";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // saveUserButton
            // 
            this.saveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveUserButton.Location = new System.Drawing.Point(469, 329);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(85, 55);
            this.saveUserButton.TabIndex = 80;
            this.saveUserButton.Text = "SAVE";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPasswordLabel.Location = new System.Drawing.Point(168, 153);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(101, 28);
            this.userPasswordLabel.TabIndex = 78;
            this.userPasswordLabel.Text = "Password:";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userRoleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userRoleLabel.Location = new System.Drawing.Point(169, 301);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(56, 28);
            this.userRoleLabel.TabIndex = 77;
            this.userRoleLabel.Text = "Role:";
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userPhoneLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPhoneLabel.Location = new System.Drawing.Point(169, 273);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(74, 28);
            this.userPhoneLabel.TabIndex = 76;
            this.userPhoneLabel.Text = "Phone:";
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userAddressLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userAddressLabel.Location = new System.Drawing.Point(169, 188);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(89, 28);
            this.userAddressLabel.TabIndex = 75;
            this.userAddressLabel.Text = "Address:";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userFullNameLabel.Location = new System.Drawing.Point(169, 41);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(109, 28);
            this.userFullNameLabel.TabIndex = 74;
            this.userFullNameLabel.Text = "Full Name:";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userLoginLabel.Location = new System.Drawing.Point(169, 124);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(67, 28);
            this.userLoginLabel.TabIndex = 72;
            this.userLoginLabel.Text = "Login:";
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPictureBox.Image = global::PointOfSaleApp.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(12, 41);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(137, 153);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 70;
            this.userPictureBox.TabStop = false;
            // 
            // userRoleTextBox
            // 
            this.userRoleTextBox.Location = new System.Drawing.Point(306, 301);
            this.userRoleTextBox.Name = "userRoleTextBox";
            this.userRoleTextBox.Size = new System.Drawing.Size(248, 22);
            this.userRoleTextBox.TabIndex = 69;
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Location = new System.Drawing.Point(306, 273);
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(248, 22);
            this.userPhoneTextBox.TabIndex = 68;
            // 
            // userAddressTextBox
            // 
            this.userAddressTextBox.Location = new System.Drawing.Point(306, 188);
            this.userAddressTextBox.Multiline = true;
            this.userAddressTextBox.Name = "userAddressTextBox";
            this.userAddressTextBox.Size = new System.Drawing.Size(248, 79);
            this.userAddressTextBox.TabIndex = 67;
            // 
            // userFullNameTextBox
            // 
            this.userFullNameTextBox.Location = new System.Drawing.Point(306, 41);
            this.userFullNameTextBox.Multiline = true;
            this.userFullNameTextBox.Name = "userFullNameTextBox";
            this.userFullNameTextBox.Size = new System.Drawing.Size(248, 83);
            this.userFullNameTextBox.TabIndex = 64;
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.Location = new System.Drawing.Point(306, 130);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(248, 22);
            this.userLoginTextBox.TabIndex = 65;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(306, 158);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(248, 24);
            this.userPasswordTextBox.TabIndex = 66;
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
            this.menuStrip1.TabIndex = 83;
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
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userPhoneLabel);
            this.Controls.Add(this.userAddressLabel);
            this.Controls.Add(this.userFullNameLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.userRoleTextBox);
            this.Controls.Add(this.userPhoneTextBox);
            this.Controls.Add(this.userAddressTextBox);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.Label userAddressLabel;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox userRoleTextBox;
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
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
    }
}