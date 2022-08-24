
namespace PointOfSaleApp.Forms
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.perDayButton = new System.Windows.Forms.Button();
            this.perMonthButton = new System.Windows.Forms.Button();
            this.perYearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // perDayButton
            // 
            this.perDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perDayButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perDayButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.perDayButton.Location = new System.Drawing.Point(12, 45);
            this.perDayButton.Name = "perDayButton";
            this.perDayButton.Size = new System.Drawing.Size(183, 113);
            this.perDayButton.TabIndex = 85;
            this.perDayButton.Text = "PER DAY";
            this.perDayButton.UseVisualStyleBackColor = true;
            this.perDayButton.Click += new System.EventHandler(this.perDayButton_Click);
            // 
            // perMonthButton
            // 
            this.perMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perMonthButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perMonthButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.perMonthButton.Location = new System.Drawing.Point(201, 45);
            this.perMonthButton.Name = "perMonthButton";
            this.perMonthButton.Size = new System.Drawing.Size(183, 113);
            this.perMonthButton.TabIndex = 86;
            this.perMonthButton.Text = "PER MONTH";
            this.perMonthButton.UseVisualStyleBackColor = true;
            this.perMonthButton.Click += new System.EventHandler(this.perMonthButton_Click);
            // 
            // perYearButton
            // 
            this.perYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perYearButton.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perYearButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.perYearButton.Location = new System.Drawing.Point(390, 45);
            this.perYearButton.Name = "perYearButton";
            this.perYearButton.Size = new System.Drawing.Size(183, 113);
            this.perYearButton.TabIndex = 87;
            this.perYearButton.Text = "PER YEAR";
            this.perYearButton.UseVisualStyleBackColor = true;
            this.perYearButton.Click += new System.EventHandler(this.perYearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 30);
            this.menuStrip1.TabIndex = 89;
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
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(589, 177);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.perYearButton);
            this.Controls.Add(this.perMonthButton);
            this.Controls.Add(this.perDayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSi - Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportsForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button perDayButton;
        private System.Windows.Forms.Button perMonthButton;
        private System.Windows.Forms.Button perYearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}