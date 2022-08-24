
namespace PointOfSaleApp.Forms
{
    partial class PaymentMethodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethodForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentMethodButton = new System.Windows.Forms.Button();
            this.paymentMethodGridView = new System.Windows.Forms.DataGridView();
            this.paymentNameLabel = new System.Windows.Forms.Label();
            this.paymentIDLabel = new System.Windows.Forms.Label();
            this.paymentNameTextBox = new System.Windows.Forms.TextBox();
            this.paymentIDTextBox = new System.Windows.Forms.TextBox();
            this.userLogoControl1 = new PointOfSaleApp.UserLogoControl();
            this.listLabel = new System.Windows.Forms.Label();
            this.removePaymentMethodButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 27;
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
            // addPaymentMethodButton
            // 
            this.addPaymentMethodButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addPaymentMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPaymentMethodButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPaymentMethodButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addPaymentMethodButton.Location = new System.Drawing.Point(794, 434);
            this.addPaymentMethodButton.Name = "addPaymentMethodButton";
            this.addPaymentMethodButton.Size = new System.Drawing.Size(85, 55);
            this.addPaymentMethodButton.TabIndex = 38;
            this.addPaymentMethodButton.Text = "ADD";
            this.addPaymentMethodButton.UseVisualStyleBackColor = false;
            this.addPaymentMethodButton.Click += new System.EventHandler(this.addPaymentMethodButton_Click);
            // 
            // paymentMethodGridView
            // 
            this.paymentMethodGridView.AllowUserToAddRows = false;
            this.paymentMethodGridView.AllowUserToDeleteRows = false;
            this.paymentMethodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentMethodGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentMethodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentMethodGridView.Location = new System.Drawing.Point(17, 224);
            this.paymentMethodGridView.MultiSelect = false;
            this.paymentMethodGridView.Name = "paymentMethodGridView";
            this.paymentMethodGridView.ReadOnly = true;
            this.paymentMethodGridView.RowHeadersWidth = 51;
            this.paymentMethodGridView.RowTemplate.Height = 24;
            this.paymentMethodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentMethodGridView.Size = new System.Drawing.Size(431, 367);
            this.paymentMethodGridView.TabIndex = 42;
            this.paymentMethodGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentMethodGridView_CellClick);
            // 
            // paymentNameLabel
            // 
            this.paymentNameLabel.AutoSize = true;
            this.paymentNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.paymentNameLabel.Location = new System.Drawing.Point(468, 333);
            this.paymentNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.paymentNameLabel.Name = "paymentNameLabel";
            this.paymentNameLabel.Size = new System.Drawing.Size(150, 28);
            this.paymentNameLabel.TabIndex = 46;
            this.paymentNameLabel.Text = "Payment Name:";
            // 
            // paymentIDLabel
            // 
            this.paymentIDLabel.AutoSize = true;
            this.paymentIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.paymentIDLabel.Location = new System.Drawing.Point(468, 305);
            this.paymentIDLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.paymentIDLabel.Name = "paymentIDLabel";
            this.paymentIDLabel.Size = new System.Drawing.Size(117, 28);
            this.paymentIDLabel.TabIndex = 45;
            this.paymentIDLabel.Text = "Payment ID:";
            // 
            // paymentNameTextBox
            // 
            this.paymentNameTextBox.Location = new System.Drawing.Point(643, 339);
            this.paymentNameTextBox.Name = "paymentNameTextBox";
            this.paymentNameTextBox.Size = new System.Drawing.Size(327, 22);
            this.paymentNameTextBox.TabIndex = 44;
            // 
            // paymentIDTextBox
            // 
            this.paymentIDTextBox.Enabled = false;
            this.paymentIDTextBox.Location = new System.Drawing.Point(643, 311);
            this.paymentIDTextBox.Name = "paymentIDTextBox";
            this.paymentIDTextBox.Size = new System.Drawing.Size(327, 22);
            this.paymentIDTextBox.TabIndex = 43;
            this.paymentIDTextBox.Text = "0";
            // 
            // userLogoControl1
            // 
            this.userLogoControl1.Location = new System.Drawing.Point(0, 31);
            this.userLogoControl1.Name = "userLogoControl1";
            this.userLogoControl1.Size = new System.Drawing.Size(982, 157);
            this.userLogoControl1.TabIndex = 47;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.listLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listLabel.Location = new System.Drawing.Point(12, 191);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(240, 30);
            this.listLabel.TabIndex = 48;
            this.listLabel.Text = "Payment Method List:";
            // 
            // removePaymentMethodButton
            // 
            this.removePaymentMethodButton.BackColor = System.Drawing.Color.Tomato;
            this.removePaymentMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePaymentMethodButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePaymentMethodButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.removePaymentMethodButton.Location = new System.Drawing.Point(885, 434);
            this.removePaymentMethodButton.Name = "removePaymentMethodButton";
            this.removePaymentMethodButton.Size = new System.Drawing.Size(85, 55);
            this.removePaymentMethodButton.TabIndex = 49;
            this.removePaymentMethodButton.Text = "REMOVE";
            this.removePaymentMethodButton.UseVisualStyleBackColor = false;
            this.removePaymentMethodButton.Click += new System.EventHandler(this.removePaymentMethodButton_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.BackColor = System.Drawing.Color.PeachPuff;
            this.clearDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDataButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDataButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clearDataButton.Location = new System.Drawing.Point(473, 434);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(85, 55);
            this.clearDataButton.TabIndex = 50;
            this.clearDataButton.Text = "CLEAR DATA";
            this.clearDataButton.UseVisualStyleBackColor = false;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // PaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.removePaymentMethodButton);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.userLogoControl1);
            this.Controls.Add(this.paymentNameLabel);
            this.Controls.Add(this.paymentIDLabel);
            this.Controls.Add(this.paymentNameTextBox);
            this.Controls.Add(this.paymentIDTextBox);
            this.Controls.Add(this.paymentMethodGridView);
            this.Controls.Add(this.addPaymentMethodButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentMethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSi - Payment Method";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentMethodForm_FormClosing);
            this.Load += new System.EventHandler(this.PaymentMethodForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addPaymentMethodButton;
        private System.Windows.Forms.DataGridView paymentMethodGridView;
        private System.Windows.Forms.Label paymentNameLabel;
        private System.Windows.Forms.Label paymentIDLabel;
        private System.Windows.Forms.TextBox paymentNameTextBox;
        private System.Windows.Forms.TextBox paymentIDTextBox;
        private UserLogoControl userLogoControl1;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button removePaymentMethodButton;
        private System.Windows.Forms.Button clearDataButton;
    }
}