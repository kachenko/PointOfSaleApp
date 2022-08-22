
namespace PointOfSaleApp.Forms.Reports
{
    partial class InfoForReportsForm
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
            this.restaurantNameLbl = new System.Windows.Forms.Label();
            this.restaurantNameTextBox = new System.Windows.Forms.TextBox();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.restaurantAddressTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantNameLbl
            // 
            this.restaurantNameLbl.AutoSize = true;
            this.restaurantNameLbl.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantNameLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.restaurantNameLbl.Location = new System.Drawing.Point(12, 40);
            this.restaurantNameLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.restaurantNameLbl.Name = "restaurantNameLbl";
            this.restaurantNameLbl.Size = new System.Drawing.Size(145, 23);
            this.restaurantNameLbl.TabIndex = 55;
            this.restaurantNameLbl.Text = "Restaurant Name:";
            // 
            // restaurantNameTextBox
            // 
            this.restaurantNameTextBox.Location = new System.Drawing.Point(200, 43);
            this.restaurantNameTextBox.Name = "restaurantNameTextBox";
            this.restaurantNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.restaurantNameTextBox.TabIndex = 54;
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishNameLabel.Location = new System.Drawing.Point(12, 70);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(159, 23);
            this.dishNameLabel.TabIndex = 53;
            this.dishNameLabel.Text = "Restaurant Address:";
            // 
            // restaurantAddressTextBox
            // 
            this.restaurantAddressTextBox.Location = new System.Drawing.Point(200, 71);
            this.restaurantAddressTextBox.Name = "restaurantAddressTextBox";
            this.restaurantAddressTextBox.Size = new System.Drawing.Size(298, 22);
            this.restaurantAddressTextBox.TabIndex = 52;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 28);
            this.menuStrip1.TabIndex = 58;
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
            // saveInfoButton
            // 
            this.saveInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveInfoButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInfoButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.saveInfoButton.Location = new System.Drawing.Point(413, 100);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(85, 55);
            this.saveInfoButton.TabIndex = 59;
            this.saveInfoButton.Text = "SAVE";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // InfoForReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(513, 167);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.restaurantNameLbl);
            this.Controls.Add(this.restaurantNameTextBox);
            this.Controls.Add(this.dishNameLabel);
            this.Controls.Add(this.restaurantAddressTextBox);
            this.Name = "InfoForReportsForm";
            this.Text = "POSi - Information For Reports";
            this.Load += new System.EventHandler(this.InfoForReportsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restaurantNameLbl;
        private System.Windows.Forms.TextBox restaurantNameTextBox;
        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.TextBox restaurantAddressTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button saveInfoButton;
    }
}