
namespace PointOfSaleApp.Forms
{
    partial class AddEditTablesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.tableNrLabel = new System.Windows.Forms.Label();
            this.tableNrTextBox = new System.Windows.Forms.TextBox();
            this.addTableButton = new System.Windows.Forms.Button();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.userMenuControl1 = new PointOfSaleApp.UserMenuControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(16, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 222);
            this.panel1.TabIndex = 0;
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tablesLabel.Location = new System.Drawing.Point(2, 30);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(116, 38);
            this.tablesLabel.TabIndex = 43;
            this.tablesLabel.Text = "TABLES";
            // 
            // tableNrLabel
            // 
            this.tableNrLabel.AutoSize = true;
            this.tableNrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tableNrLabel.Location = new System.Drawing.Point(41, 87);
            this.tableNrLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.tableNrLabel.Name = "tableNrLabel";
            this.tableNrLabel.Size = new System.Drawing.Size(77, 23);
            this.tableNrLabel.TabIndex = 46;
            this.tableNrLabel.Text = "Number:";
            // 
            // tableNrTextBox
            // 
            this.tableNrTextBox.Location = new System.Drawing.Point(130, 88);
            this.tableNrTextBox.Name = "tableNrTextBox";
            this.tableNrTextBox.Size = new System.Drawing.Size(292, 22);
            this.tableNrTextBox.TabIndex = 45;
            this.tableNrTextBox.TextChanged += new System.EventHandler(this.tableNrTextBox_TextChanged);
            // 
            // addTableButton
            // 
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTableButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addTableButton.Location = new System.Drawing.Point(462, 72);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(85, 55);
            this.addTableButton.TabIndex = 47;
            this.addTableButton.Text = "ADD";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTableButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTableButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteTableButton.Location = new System.Drawing.Point(553, 72);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(85, 55);
            this.deleteTableButton.TabIndex = 48;
            this.deleteTableButton.Text = "DELETE";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // userMenuControl1
            // 
            this.userMenuControl1.Location = new System.Drawing.Point(-1, -1);
            this.userMenuControl1.Name = "userMenuControl1";
            this.userMenuControl1.Size = new System.Drawing.Size(652, 28);
            this.userMenuControl1.TabIndex = 49;
            // 
            // AddEditTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(650, 388);
            this.Controls.Add(this.userMenuControl1);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.tableNrLabel);
            this.Controls.Add(this.tableNrTextBox);
            this.Controls.Add(this.tablesLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddEditTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSi - Tables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTablesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tablesLabel;
        private System.Windows.Forms.Label tableNrLabel;
        private System.Windows.Forms.TextBox tableNrTextBox;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button deleteTableButton;
        private UserMenuControl userMenuControl1;
    }
}