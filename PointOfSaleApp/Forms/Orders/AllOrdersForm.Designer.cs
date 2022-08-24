
namespace PointOfSaleApp.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.dataOrdersGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.printBillButton = new System.Windows.Forms.Button();
            this.dishQuantLabel = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.orderIsActiveTextBox = new System.Windows.Forms.TextBox();
            this.isActiveOrderLabel = new System.Windows.Forms.Label();
            this.orderFullPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderFullPriceLabel = new System.Windows.Forms.Label();
            this.orderTableTextBox = new System.Windows.Forms.TextBox();
            this.orderTableLabel = new System.Windows.Forms.Label();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.dateOrderLabel = new System.Windows.Forms.Label();
            this.dataDishesGridView = new System.Windows.Forms.DataGridView();
            this.activeOrdersCheckBox = new System.Windows.Forms.CheckBox();
            this.orderCloseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishesGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOrdersGridView
            // 
            this.dataOrdersGridView.AllowUserToAddRows = false;
            this.dataOrdersGridView.AllowUserToDeleteRows = false;
            this.dataOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrdersGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.table_nr,
            this.datetime,
            this.price,
            this.isActive});
            this.dataOrdersGridView.Location = new System.Drawing.Point(12, 118);
            this.dataOrdersGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataOrdersGridView.MultiSelect = false;
            this.dataOrdersGridView.Name = "dataOrdersGridView";
            this.dataOrdersGridView.ReadOnly = true;
            this.dataOrdersGridView.RowHeadersWidth = 51;
            this.dataOrdersGridView.RowTemplate.Height = 24;
            this.dataOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrdersGridView.Size = new System.Drawing.Size(665, 412);
            this.dataOrdersGridView.TabIndex = 44;
            this.dataOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrdersGridView_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // table_nr
            // 
            this.table_nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.table_nr.HeaderText = "Table Nr";
            this.table_nr.MinimumWidth = 6;
            this.table_nr.Name = "table_nr";
            this.table_nr.ReadOnly = true;
            this.table_nr.Width = 92;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Date";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 69;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Active?";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Items.AddRange(new object[] {
            "All"});
            this.usersComboBox.Location = new System.Drawing.Point(72, 41);
            this.usersComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(252, 24);
            this.usersComboBox.TabIndex = 45;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Orders:";
            // 
            // editOrderButton
            // 
            this.editOrderButton.BackColor = System.Drawing.Color.SandyBrown;
            this.editOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editOrderButton.Location = new System.Drawing.Point(12, 537);
            this.editOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(85, 55);
            this.editOrderButton.TabIndex = 47;
            this.editOrderButton.Text = "EDIT";
            this.editOrderButton.UseVisualStyleBackColor = false;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOrderButton.Location = new System.Drawing.Point(103, 537);
            this.deleteOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(85, 55);
            this.deleteOrderButton.TabIndex = 48;
            this.deleteOrderButton.Text = "DELETE";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // printBillButton
            // 
            this.printBillButton.BackColor = System.Drawing.Color.LightYellow;
            this.printBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBillButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printBillButton.Location = new System.Drawing.Point(592, 537);
            this.printBillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBillButton.Name = "printBillButton";
            this.printBillButton.Size = new System.Drawing.Size(85, 55);
            this.printBillButton.TabIndex = 49;
            this.printBillButton.Text = "PRINT BILL";
            this.printBillButton.UseVisualStyleBackColor = false;
            this.printBillButton.Click += new System.EventHandler(this.printBillButton_Click);
            // 
            // dishQuantLabel
            // 
            this.dishQuantLabel.AutoSize = true;
            this.dishQuantLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishQuantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishQuantLabel.Location = new System.Drawing.Point(12, 39);
            this.dishQuantLabel.Name = "dishQuantLabel";
            this.dishQuantLabel.Size = new System.Drawing.Size(54, 25);
            this.dishQuantLabel.TabIndex = 50;
            this.dishQuantLabel.Text = "User:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(827, 76);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(173, 27);
            this.orderIDTextBox.TabIndex = 61;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderIDLabel.Location = new System.Drawing.Point(703, 79);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(79, 23);
            this.orderIDLabel.TabIndex = 60;
            this.orderIDLabel.Text = "Order ID:";
            // 
            // orderIsActiveTextBox
            // 
            this.orderIsActiveTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderIsActiveTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIsActiveTextBox.Location = new System.Drawing.Point(827, 107);
            this.orderIsActiveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderIsActiveTextBox.Name = "orderIsActiveTextBox";
            this.orderIsActiveTextBox.ReadOnly = true;
            this.orderIsActiveTextBox.Size = new System.Drawing.Size(231, 27);
            this.orderIsActiveTextBox.TabIndex = 58;
            // 
            // isActiveOrderLabel
            // 
            this.isActiveOrderLabel.AutoSize = true;
            this.isActiveOrderLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isActiveOrderLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.isActiveOrderLabel.Location = new System.Drawing.Point(703, 107);
            this.isActiveOrderLabel.MaximumSize = new System.Drawing.Size(251, 0);
            this.isActiveOrderLabel.Name = "isActiveOrderLabel";
            this.isActiveOrderLabel.Size = new System.Drawing.Size(75, 23);
            this.isActiveOrderLabel.TabIndex = 55;
            this.isActiveOrderLabel.Text = "Is Active:";
            // 
            // orderFullPriceTextBox
            // 
            this.orderFullPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderFullPriceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderFullPriceTextBox.Location = new System.Drawing.Point(827, 202);
            this.orderFullPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderFullPriceTextBox.Name = "orderFullPriceTextBox";
            this.orderFullPriceTextBox.ReadOnly = true;
            this.orderFullPriceTextBox.Size = new System.Drawing.Size(231, 27);
            this.orderFullPriceTextBox.TabIndex = 54;
            // 
            // orderFullPriceLabel
            // 
            this.orderFullPriceLabel.AutoSize = true;
            this.orderFullPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFullPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderFullPriceLabel.Location = new System.Drawing.Point(703, 207);
            this.orderFullPriceLabel.Name = "orderFullPriceLabel";
            this.orderFullPriceLabel.Size = new System.Drawing.Size(82, 23);
            this.orderFullPriceLabel.TabIndex = 53;
            this.orderFullPriceLabel.Text = "Full Price:";
            // 
            // orderTableTextBox
            // 
            this.orderTableTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTableTextBox.Location = new System.Drawing.Point(827, 140);
            this.orderTableTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderTableTextBox.Name = "orderTableTextBox";
            this.orderTableTextBox.ReadOnly = true;
            this.orderTableTextBox.Size = new System.Drawing.Size(231, 27);
            this.orderTableTextBox.TabIndex = 64;
            // 
            // orderTableLabel
            // 
            this.orderTableLabel.AutoSize = true;
            this.orderTableLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTableLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderTableLabel.Location = new System.Drawing.Point(701, 143);
            this.orderTableLabel.Name = "orderTableLabel";
            this.orderTableLabel.Size = new System.Drawing.Size(123, 23);
            this.orderTableLabel.TabIndex = 63;
            this.orderTableLabel.Text = "Table Number:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDateTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTextBox.Location = new System.Drawing.Point(827, 171);
            this.orderDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.ReadOnly = true;
            this.orderDateTextBox.Size = new System.Drawing.Size(231, 27);
            this.orderDateTextBox.TabIndex = 66;
            // 
            // dateOrderLabel
            // 
            this.dateOrderLabel.AutoSize = true;
            this.dateOrderLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateOrderLabel.Location = new System.Drawing.Point(701, 174);
            this.dateOrderLabel.Name = "dateOrderLabel";
            this.dateOrderLabel.Size = new System.Drawing.Size(49, 23);
            this.dateOrderLabel.TabIndex = 65;
            this.dateOrderLabel.Text = "Date:";
            // 
            // dataDishesGridView
            // 
            this.dataDishesGridView.AllowUserToAddRows = false;
            this.dataDishesGridView.AllowUserToDeleteRows = false;
            this.dataDishesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDishesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDishesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDishesGridView.Location = new System.Drawing.Point(707, 242);
            this.dataDishesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDishesGridView.MultiSelect = false;
            this.dataDishesGridView.Name = "dataDishesGridView";
            this.dataDishesGridView.ReadOnly = true;
            this.dataDishesGridView.RowHeadersWidth = 51;
            this.dataDishesGridView.RowTemplate.Height = 24;
            this.dataDishesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDishesGridView.Size = new System.Drawing.Size(349, 287);
            this.dataDishesGridView.TabIndex = 67;
            // 
            // activeOrdersCheckBox
            // 
            this.activeOrdersCheckBox.AutoSize = true;
            this.activeOrdersCheckBox.Checked = true;
            this.activeOrdersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeOrdersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeOrdersCheckBox.Location = new System.Drawing.Point(467, 84);
            this.activeOrdersCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activeOrdersCheckBox.Name = "activeOrdersCheckBox";
            this.activeOrdersCheckBox.Size = new System.Drawing.Size(180, 24);
            this.activeOrdersCheckBox.TabIndex = 70;
            this.activeOrdersCheckBox.Text = "Show Active Orders";
            this.activeOrdersCheckBox.UseVisualStyleBackColor = true;
            this.activeOrdersCheckBox.CheckedChanged += new System.EventHandler(this.activeOrdersCheckBox_CheckedChanged);
            // 
            // orderCloseButton
            // 
            this.orderCloseButton.BackColor = System.Drawing.Color.LightCoral;
            this.orderCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderCloseButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.orderCloseButton.Location = new System.Drawing.Point(971, 534);
            this.orderCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderCloseButton.Name = "orderCloseButton";
            this.orderCloseButton.Size = new System.Drawing.Size(85, 55);
            this.orderCloseButton.TabIndex = 71;
            this.orderCloseButton.Text = "CLOSE ORDER";
            this.orderCloseButton.UseVisualStyleBackColor = false;
            this.orderCloseButton.Click += new System.EventHandler(this.orderCloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 72;
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1071, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.orderCloseButton);
            this.Controls.Add(this.activeOrdersCheckBox);
            this.Controls.Add(this.dataDishesGridView);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(this.dateOrderLabel);
            this.Controls.Add(this.orderTableTextBox);
            this.Controls.Add(this.orderTableLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.orderIsActiveTextBox);
            this.Controls.Add(this.isActiveOrderLabel);
            this.Controls.Add(this.orderFullPriceTextBox);
            this.Controls.Add(this.orderFullPriceLabel);
            this.Controls.Add(this.dishQuantLabel);
            this.Controls.Add(this.printBillButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.dataOrdersGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishesGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataOrdersGridView;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button printBillButton;
        private System.Windows.Forms.Label dishQuantLabel;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.TextBox orderIsActiveTextBox;
        private System.Windows.Forms.Label isActiveOrderLabel;
        private System.Windows.Forms.TextBox orderFullPriceTextBox;
        private System.Windows.Forms.Label orderFullPriceLabel;
        private System.Windows.Forms.TextBox orderTableTextBox;
        private System.Windows.Forms.Label orderTableLabel;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.Label dateOrderLabel;
        private System.Windows.Forms.DataGridView dataDishesGridView;
        private System.Windows.Forms.CheckBox activeOrdersCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.Button orderCloseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}