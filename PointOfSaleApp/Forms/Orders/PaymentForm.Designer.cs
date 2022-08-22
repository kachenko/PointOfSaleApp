
namespace PointOfSaleApp.Forms
{
    partial class PaymentForm
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
            this.dataPriceGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.itemOrderLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.orderReceivedLabel = new System.Windows.Forms.Label();
            this.orderReceivedTextBox = new System.Windows.Forms.TextBox();
            this.orderChangeTextBox = new System.Windows.Forms.TextBox();
            this.orderChangeLabel = new System.Windows.Forms.Label();
            this.calculateOrderButton = new System.Windows.Forms.Button();
            this.printBillButton = new System.Windows.Forms.Button();
            this.closeOrderButton = new System.Windows.Forms.Button();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.userMenuControl1 = new PointOfSaleApp.UserMenuControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataPriceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPriceGridView
            // 
            this.dataPriceGridView.AllowUserToAddRows = false;
            this.dataPriceGridView.AllowUserToDeleteRows = false;
            this.dataPriceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPriceGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPriceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPriceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantity,
            this.price_dish});
            this.dataPriceGridView.Location = new System.Drawing.Point(12, 70);
            this.dataPriceGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPriceGridView.Name = "dataPriceGridView";
            this.dataPriceGridView.ReadOnly = true;
            this.dataPriceGridView.RowHeadersWidth = 51;
            this.dataPriceGridView.RowTemplate.Height = 24;
            this.dataPriceGridView.Size = new System.Drawing.Size(385, 403);
            this.dataPriceGridView.TabIndex = 45;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price_dish
            // 
            this.price_dish.HeaderText = "Price";
            this.price_dish.MinimumWidth = 6;
            this.price_dish.Name = "price_dish";
            this.price_dish.ReadOnly = true;
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTotalTextBox.Location = new System.Drawing.Point(540, 193);
            this.orderTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.ReadOnly = true;
            this.orderTotalTextBox.Size = new System.Drawing.Size(136, 45);
            this.orderTotalTextBox.TabIndex = 46;
            // 
            // itemOrderLabel
            // 
            this.itemOrderLabel.AutoSize = true;
            this.itemOrderLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.itemOrderLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.itemOrderLabel.Location = new System.Drawing.Point(12, 37);
            this.itemOrderLabel.Name = "itemOrderLabel";
            this.itemOrderLabel.Size = new System.Drawing.Size(76, 30);
            this.itemOrderLabel.TabIndex = 47;
            this.itemOrderLabel.Text = "Items:";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTotalLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderTotalLabel.Location = new System.Drawing.Point(445, 208);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(64, 23);
            this.orderTotalLabel.TabIndex = 61;
            this.orderTotalLabel.Text = "TOTAL:";
            // 
            // orderReceivedLabel
            // 
            this.orderReceivedLabel.AutoSize = true;
            this.orderReceivedLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderReceivedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderReceivedLabel.Location = new System.Drawing.Point(445, 257);
            this.orderReceivedLabel.Name = "orderReceivedLabel";
            this.orderReceivedLabel.Size = new System.Drawing.Size(89, 23);
            this.orderReceivedLabel.TabIndex = 62;
            this.orderReceivedLabel.Text = "RECEIVED:";
            // 
            // orderReceivedTextBox
            // 
            this.orderReceivedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderReceivedTextBox.Location = new System.Drawing.Point(540, 242);
            this.orderReceivedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderReceivedTextBox.Name = "orderReceivedTextBox";
            this.orderReceivedTextBox.Size = new System.Drawing.Size(136, 45);
            this.orderReceivedTextBox.TabIndex = 63;
            // 
            // orderChangeTextBox
            // 
            this.orderChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderChangeTextBox.Location = new System.Drawing.Point(540, 291);
            this.orderChangeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderChangeTextBox.Name = "orderChangeTextBox";
            this.orderChangeTextBox.ReadOnly = true;
            this.orderChangeTextBox.Size = new System.Drawing.Size(136, 45);
            this.orderChangeTextBox.TabIndex = 65;
            // 
            // orderChangeLabel
            // 
            this.orderChangeLabel.AutoSize = true;
            this.orderChangeLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderChangeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderChangeLabel.Location = new System.Drawing.Point(445, 306);
            this.orderChangeLabel.Name = "orderChangeLabel";
            this.orderChangeLabel.Size = new System.Drawing.Size(82, 23);
            this.orderChangeLabel.TabIndex = 64;
            this.orderChangeLabel.Text = "CHANGE:";
            // 
            // calculateOrderButton
            // 
            this.calculateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.calculateOrderButton.Location = new System.Drawing.Point(684, 242);
            this.calculateOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateOrderButton.Name = "calculateOrderButton";
            this.calculateOrderButton.Size = new System.Drawing.Size(107, 55);
            this.calculateOrderButton.TabIndex = 66;
            this.calculateOrderButton.Text = "CALCULATE";
            this.calculateOrderButton.UseVisualStyleBackColor = true;
            this.calculateOrderButton.Click += new System.EventHandler(this.calculateOrderButton_Click);
            // 
            // printBillButton
            // 
            this.printBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBillButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printBillButton.Location = new System.Drawing.Point(569, 418);
            this.printBillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBillButton.Name = "printBillButton";
            this.printBillButton.Size = new System.Drawing.Size(107, 55);
            this.printBillButton.TabIndex = 67;
            this.printBillButton.Text = "PRINT BILL";
            this.printBillButton.UseVisualStyleBackColor = true;
            this.printBillButton.Click += new System.EventHandler(this.printBillButton_Click);
            // 
            // closeOrderButton
            // 
            this.closeOrderButton.BackColor = System.Drawing.Color.Tomato;
            this.closeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeOrderButton.Location = new System.Drawing.Point(684, 418);
            this.closeOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeOrderButton.Name = "closeOrderButton";
            this.closeOrderButton.Size = new System.Drawing.Size(107, 55);
            this.closeOrderButton.TabIndex = 68;
            this.closeOrderButton.Text = "CLOSE ORDER";
            this.closeOrderButton.UseVisualStyleBackColor = false;
            this.closeOrderButton.Click += new System.EventHandler(this.closeOrderButton_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(556, 59);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(109, 25);
            this.orderIDTextBox.TabIndex = 70;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderIDLabel.Location = new System.Drawing.Point(471, 62);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(79, 23);
            this.orderIDLabel.TabIndex = 69;
            this.orderIDLabel.Text = "Order ID:";
            // 
            // editOrderButton
            // 
            this.editOrderButton.BackColor = System.Drawing.Color.Linen;
            this.editOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editOrderButton.Location = new System.Drawing.Point(12, 477);
            this.editOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(107, 55);
            this.editOrderButton.TabIndex = 71;
            this.editOrderButton.Text = "EDIT ORDER";
            this.editOrderButton.UseVisualStyleBackColor = false;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.paymentTypeLabel.Location = new System.Drawing.Point(412, 89);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(134, 25);
            this.paymentTypeLabel.TabIndex = 73;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "All"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(556, 90);
            this.paymentTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(229, 24);
            this.paymentTypeComboBox.TabIndex = 72;
            this.paymentTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.paymentTypeComboBox_SelectionChangeCommitted);
            // 
            // userMenuControl1
            // 
            this.userMenuControl1.Location = new System.Drawing.Point(0, -3);
            this.userMenuControl1.Name = "userMenuControl1";
            this.userMenuControl1.Size = new System.Drawing.Size(982, 28);
            this.userMenuControl1.TabIndex = 74;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(803, 547);
            this.Controls.Add(this.userMenuControl1);
            this.Controls.Add(this.orderReceivedTextBox);
            this.Controls.Add(this.orderReceivedLabel);
            this.Controls.Add(this.orderChangeTextBox);
            this.Controls.Add(this.orderTotalTextBox);
            this.Controls.Add(this.calculateOrderButton);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.orderChangeLabel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.closeOrderButton);
            this.Controls.Add(this.printBillButton);
            this.Controls.Add(this.itemOrderLabel);
            this.Controls.Add(this.dataPriceGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPriceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataPriceGridView;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.Label itemOrderLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label orderReceivedLabel;
        private System.Windows.Forms.TextBox orderReceivedTextBox;
        private System.Windows.Forms.TextBox orderChangeTextBox;
        private System.Windows.Forms.Label orderChangeLabel;
        private System.Windows.Forms.Button calculateOrderButton;
        private System.Windows.Forms.Button printBillButton;
        private System.Windows.Forms.Button closeOrderButton;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_dish;
        private UserMenuControl userMenuControl1;
    }
}