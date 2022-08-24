
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.changeImageButton = new System.Windows.Forms.Button();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.userPasswordLabel = new System.Windows.Forms.Label();
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
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswdButton = new System.Windows.Forms.Button();
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
            this.saveUserButton.BackColor = System.Drawing.Color.GreenYellow;
            this.saveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveUserButton.Location = new System.Drawing.Point(469, 329);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(85, 55);
            this.saveUserButton.TabIndex = 80;
            this.saveUserButton.Text = "SAVE";
            this.saveUserButton.UseVisualStyleBackColor = false;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPasswordLabel.Location = new System.Drawing.Point(168, 153);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(99, 28);
            this.userPasswordLabel.TabIndex = 78;
            this.userPasswordLabel.Text = "Password:";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRoleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userRoleLabel.Location = new System.Drawing.Point(169, 301);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(55, 28);
            this.userRoleLabel.TabIndex = 77;
            this.userRoleLabel.Text = "Role:";
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPhoneLabel.Location = new System.Drawing.Point(169, 273);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(72, 28);
            this.userPhoneLabel.TabIndex = 76;
            this.userPhoneLabel.Text = "Phone:";
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAddressLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userAddressLabel.Location = new System.Drawing.Point(169, 186);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(87, 28);
            this.userAddressLabel.TabIndex = 75;
            this.userAddressLabel.Text = "Address:";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userFullNameLabel.Location = new System.Drawing.Point(169, 41);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(104, 28);
            this.userFullNameLabel.TabIndex = 74;
            this.userFullNameLabel.Text = "Full Name:";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userLoginLabel.Location = new System.Drawing.Point(169, 124);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(66, 28);
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
            // userRoleComboBox
            // 
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(305, 301);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(249, 24);
            this.userRoleComboBox.TabIndex = 105;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 28);
            this.menuStrip1.TabIndex = 106;
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
            // changePasswdButton
            // 
            this.changePasswdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswdButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswdButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changePasswdButton.Location = new System.Drawing.Point(12, 329);
            this.changePasswdButton.Name = "changePasswdButton";
            this.changePasswdButton.Size = new System.Drawing.Size(133, 55);
            this.changePasswdButton.TabIndex = 107;
            this.changePasswdButton.Text = "SET DEFAULT PASSWORD";
            this.changePasswdButton.UseVisualStyleBackColor = true;
            this.changePasswdButton.Click += new System.EventHandler(this.changePasswdButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.changePasswdButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userRoleComboBox);
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
            this.Controls.Add(this.userPhoneTextBox);
            this.Controls.Add(this.userAddressTextBox);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(this.userLoginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POSi - Add User";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
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
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button changePasswdButton;
    }
}