
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishesGridView)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(803, 28);
            this.menuStrip1.TabIndex = 43;
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
            this.dataOrdersGridView.Location = new System.Drawing.Point(9, 96);
            this.dataOrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataOrdersGridView.MultiSelect = false;
            this.dataOrdersGridView.Name = "dataOrdersGridView";
            this.dataOrdersGridView.ReadOnly = true;
            this.dataOrdersGridView.RowHeadersWidth = 51;
            this.dataOrdersGridView.RowTemplate.Height = 24;
            this.dataOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrdersGridView.Size = new System.Drawing.Size(499, 335);
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
            this.id.Width = 48;
            // 
            // table_nr
            // 
            this.table_nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.table_nr.HeaderText = "Table Nr";
            this.table_nr.MinimumWidth = 6;
            this.table_nr.Name = "table_nr";
            this.table_nr.ReadOnly = true;
            this.table_nr.Width = 83;
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
            this.price.Width = 64;
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
            this.usersComboBox.Location = new System.Drawing.Point(54, 33);
            this.usersComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(190, 21);
            this.usersComboBox.TabIndex = 45;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Orders:";
            // 
            // editOrderButton
            // 
            this.editOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editOrderButton.Location = new System.Drawing.Point(9, 436);
            this.editOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(64, 45);
            this.editOrderButton.TabIndex = 47;
            this.editOrderButton.Text = "EDIT";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrderButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOrderButton.Location = new System.Drawing.Point(77, 436);
            this.deleteOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(64, 45);
            this.deleteOrderButton.TabIndex = 48;
            this.deleteOrderButton.Text = "DELETE";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // printBillButton
            // 
            this.printBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBillButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printBillButton.Location = new System.Drawing.Point(444, 436);
            this.printBillButton.Margin = new System.Windows.Forms.Padding(2);
            this.printBillButton.Name = "printBillButton";
            this.printBillButton.Size = new System.Drawing.Size(64, 45);
            this.printBillButton.TabIndex = 49;
            this.printBillButton.Text = "PRINT BILL";
            this.printBillButton.UseVisualStyleBackColor = true;
            this.printBillButton.Click += new System.EventHandler(this.printBillButton_Click);
            // 
            // dishQuantLabel
            // 
            this.dishQuantLabel.AutoSize = true;
            this.dishQuantLabel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishQuantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishQuantLabel.Location = new System.Drawing.Point(9, 32);
            this.dishQuantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dishQuantLabel.Name = "dishQuantLabel";
            this.dishQuantLabel.Size = new System.Drawing.Size(54, 25);
            this.dishQuantLabel.TabIndex = 50;
            this.dishQuantLabel.Text = "User:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(620, 62);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(131, 25);
            this.orderIDTextBox.TabIndex = 61;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderIDLabel.Location = new System.Drawing.Point(527, 64);
            this.orderIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(79, 23);
            this.orderIDLabel.TabIndex = 60;
            this.orderIDLabel.Text = "Order ID:";
            // 
            // orderIsActiveTextBox
            // 
            this.orderIsActiveTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderIsActiveTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIsActiveTextBox.Location = new System.Drawing.Point(620, 87);
            this.orderIsActiveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderIsActiveTextBox.Name = "orderIsActiveTextBox";
            this.orderIsActiveTextBox.ReadOnly = true;
            this.orderIsActiveTextBox.Size = new System.Drawing.Size(174, 27);
            this.orderIsActiveTextBox.TabIndex = 58;
            // 
            // isActiveOrderLabel
            // 
            this.isActiveOrderLabel.AutoSize = true;
            this.isActiveOrderLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isActiveOrderLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.isActiveOrderLabel.Location = new System.Drawing.Point(527, 87);
            this.isActiveOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isActiveOrderLabel.MaximumSize = new System.Drawing.Size(188, 0);
            this.isActiveOrderLabel.Name = "isActiveOrderLabel";
            this.isActiveOrderLabel.Size = new System.Drawing.Size(75, 23);
            this.isActiveOrderLabel.TabIndex = 55;
            this.isActiveOrderLabel.Text = "Is Active:";
            // 
            // orderFullPriceTextBox
            // 
            this.orderFullPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderFullPriceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderFullPriceTextBox.Location = new System.Drawing.Point(620, 164);
            this.orderFullPriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderFullPriceTextBox.Name = "orderFullPriceTextBox";
            this.orderFullPriceTextBox.ReadOnly = true;
            this.orderFullPriceTextBox.Size = new System.Drawing.Size(174, 27);
            this.orderFullPriceTextBox.TabIndex = 54;
            // 
            // orderFullPriceLabel
            // 
            this.orderFullPriceLabel.AutoSize = true;
            this.orderFullPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFullPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderFullPriceLabel.Location = new System.Drawing.Point(527, 168);
            this.orderFullPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderFullPriceLabel.Name = "orderFullPriceLabel";
            this.orderFullPriceLabel.Size = new System.Drawing.Size(82, 23);
            this.orderFullPriceLabel.TabIndex = 53;
            this.orderFullPriceLabel.Text = "Full Price:";
            // 
            // orderTableTextBox
            // 
            this.orderTableTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTableTextBox.Location = new System.Drawing.Point(620, 114);
            this.orderTableTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderTableTextBox.Name = "orderTableTextBox";
            this.orderTableTextBox.ReadOnly = true;
            this.orderTableTextBox.Size = new System.Drawing.Size(174, 25);
            this.orderTableTextBox.TabIndex = 64;
            // 
            // orderTableLabel
            // 
            this.orderTableLabel.AutoSize = true;
            this.orderTableLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTableLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderTableLabel.Location = new System.Drawing.Point(526, 116);
            this.orderTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderTableLabel.Name = "orderTableLabel";
            this.orderTableLabel.Size = new System.Drawing.Size(123, 23);
            this.orderTableLabel.TabIndex = 63;
            this.orderTableLabel.Text = "Table Number:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDateTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTextBox.Location = new System.Drawing.Point(620, 139);
            this.orderDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.ReadOnly = true;
            this.orderDateTextBox.Size = new System.Drawing.Size(174, 25);
            this.orderDateTextBox.TabIndex = 66;
            // 
            // dateOrderLabel
            // 
            this.dateOrderLabel.AutoSize = true;
            this.dateOrderLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOrderLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateOrderLabel.Location = new System.Drawing.Point(526, 141);
            this.dateOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.dataDishesGridView.Location = new System.Drawing.Point(530, 197);
            this.dataDishesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataDishesGridView.MultiSelect = false;
            this.dataDishesGridView.Name = "dataDishesGridView";
            this.dataDishesGridView.ReadOnly = true;
            this.dataDishesGridView.RowHeadersWidth = 51;
            this.dataDishesGridView.RowTemplate.Height = 24;
            this.dataDishesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDishesGridView.Size = new System.Drawing.Size(262, 233);
            this.dataDishesGridView.TabIndex = 67;
            // 
            // activeOrdersCheckBox
            // 
            this.activeOrdersCheckBox.AutoSize = true;
            this.activeOrdersCheckBox.Checked = true;
            this.activeOrdersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeOrdersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeOrdersCheckBox.Location = new System.Drawing.Point(350, 68);
            this.activeOrdersCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.activeOrdersCheckBox.Name = "activeOrdersCheckBox";
            this.activeOrdersCheckBox.Size = new System.Drawing.Size(180, 24);
            this.activeOrdersCheckBox.TabIndex = 70;
            this.activeOrdersCheckBox.Text = "Show Active Orders";
            this.activeOrdersCheckBox.UseVisualStyleBackColor = true;
            this.activeOrdersCheckBox.CheckedChanged += new System.EventHandler(this.activeOrdersCheckBox_CheckedChanged);
            // 
            // orderCloseButton
            // 
            this.orderCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderCloseButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderCloseButton.Location = new System.Drawing.Point(728, 434);
            this.orderCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.orderCloseButton.Name = "orderCloseButton";
            this.orderCloseButton.Size = new System.Drawing.Size(64, 45);
            this.orderCloseButton.TabIndex = 71;
            this.orderCloseButton.Text = "CLOSE ORDER";
            this.orderCloseButton.UseVisualStyleBackColor = true;
            this.orderCloseButton.Click += new System.EventHandler(this.orderCloseButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(803, 490);
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
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishesGridView)).EndInit();
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
    }
}