
namespace PointOfSaleApp
{
	partial class NewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.dishInfoLabel = new System.Windows.Forms.Label();
            this.dishQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.dishNameTextBox = new System.Windows.Forms.TextBox();
            this.dishIDTextBox = new System.Windows.Forms.TextBox();
            this.dishIDLabel = new System.Windows.Forms.Label();
            this.dishDescTextBox = new System.Windows.Forms.TextBox();
            this.dishFullNameTextBox = new System.Windows.Forms.TextBox();
            this.dishFullNameLabel = new System.Windows.Forms.Label();
            this.dishDescriptionLabel = new System.Windows.Forms.Label();
            this.dishPriceTextBox = new System.Windows.Forms.TextBox();
            this.dishPriceLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.dishQuantLabel = new System.Windows.Forms.Label();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.categoryButtonPanel = new System.Windows.Forms.Panel();
            this.billPanel = new System.Windows.Forms.Panel();
            this.orderCreateButton = new System.Windows.Forms.Button();
            this.dataOrderGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tableNrLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.dataDishGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishQuantityUpDown)).BeginInit();
            this.billPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.dishInfoLabel);
            this.infoPanel.Controls.Add(this.dishQuantityUpDown);
            this.infoPanel.Controls.Add(this.dishNameTextBox);
            this.infoPanel.Controls.Add(this.dishIDTextBox);
            this.infoPanel.Controls.Add(this.dishIDLabel);
            this.infoPanel.Controls.Add(this.dishDescTextBox);
            this.infoPanel.Controls.Add(this.dishFullNameTextBox);
            this.infoPanel.Controls.Add(this.dishFullNameLabel);
            this.infoPanel.Controls.Add(this.dishDescriptionLabel);
            this.infoPanel.Controls.Add(this.dishPriceTextBox);
            this.infoPanel.Controls.Add(this.dishPriceLabel);
            this.infoPanel.Controls.Add(this.removeButton);
            this.infoPanel.Controls.Add(this.addProductButton);
            this.infoPanel.Controls.Add(this.dishQuantLabel);
            this.infoPanel.Controls.Add(this.dishNameLabel);
            this.infoPanel.Location = new System.Drawing.Point(396, 33);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(305, 599);
            this.infoPanel.TabIndex = 7;
            this.infoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.infoPanel_Paint);
            // 
            // dishInfoLabel
            // 
            this.dishInfoLabel.AutoSize = true;
            this.dishInfoLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishInfoLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishInfoLabel.Location = new System.Drawing.Point(5, 12);
            this.dishInfoLabel.Name = "dishInfoLabel";
            this.dishInfoLabel.Size = new System.Drawing.Size(188, 31);
            this.dishInfoLabel.TabIndex = 18;
            this.dishInfoLabel.Text = "Dish Information";
            // 
            // dishQuantityUpDown
            // 
            this.dishQuantityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishQuantityUpDown.Location = new System.Drawing.Point(107, 494);
            this.dishQuantityUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishQuantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dishQuantityUpDown.Name = "dishQuantityUpDown";
            this.dishQuantityUpDown.Size = new System.Drawing.Size(89, 27);
            this.dishQuantityUpDown.TabIndex = 17;
            this.dishQuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dishQuantityUpDown.ValueChanged += new System.EventHandler(this.dishQuantityUpDown_ValueChanged);
            // 
            // dishNameTextBox
            // 
            this.dishNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishNameTextBox.Location = new System.Drawing.Point(107, 119);
            this.dishNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishNameTextBox.Multiline = true;
            this.dishNameTextBox.Name = "dishNameTextBox";
            this.dishNameTextBox.ReadOnly = true;
            this.dishNameTextBox.Size = new System.Drawing.Size(185, 72);
            this.dishNameTextBox.TabIndex = 14;
            // 
            // dishIDTextBox
            // 
            this.dishIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishIDTextBox.Location = new System.Drawing.Point(107, 88);
            this.dishIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishIDTextBox.Name = "dishIDTextBox";
            this.dishIDTextBox.ReadOnly = true;
            this.dishIDTextBox.Size = new System.Drawing.Size(63, 25);
            this.dishIDTextBox.TabIndex = 16;
            // 
            // dishIDLabel
            // 
            this.dishIDLabel.AutoSize = true;
            this.dishIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishIDLabel.Location = new System.Drawing.Point(10, 88);
            this.dishIDLabel.Name = "dishIDLabel";
            this.dishIDLabel.Size = new System.Drawing.Size(26, 23);
            this.dishIDLabel.TabIndex = 15;
            this.dishIDLabel.Text = "ID";
            // 
            // dishDescTextBox
            // 
            this.dishDescTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishDescTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishDescTextBox.Location = new System.Drawing.Point(107, 341);
            this.dishDescTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishDescTextBox.Multiline = true;
            this.dishDescTextBox.Name = "dishDescTextBox";
            this.dishDescTextBox.ReadOnly = true;
            this.dishDescTextBox.Size = new System.Drawing.Size(185, 147);
            this.dishDescTextBox.TabIndex = 13;
            // 
            // dishFullNameTextBox
            // 
            this.dishFullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishFullNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishFullNameTextBox.Location = new System.Drawing.Point(107, 197);
            this.dishFullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishFullNameTextBox.Multiline = true;
            this.dishFullNameTextBox.Name = "dishFullNameTextBox";
            this.dishFullNameTextBox.ReadOnly = true;
            this.dishFullNameTextBox.Size = new System.Drawing.Size(185, 105);
            this.dishFullNameTextBox.TabIndex = 12;
            // 
            // dishFullNameLabel
            // 
            this.dishFullNameLabel.AutoSize = true;
            this.dishFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishFullNameLabel.Location = new System.Drawing.Point(10, 197);
            this.dishFullNameLabel.MaximumSize = new System.Drawing.Size(251, 0);
            this.dishFullNameLabel.Name = "dishFullNameLabel";
            this.dishFullNameLabel.Size = new System.Drawing.Size(91, 23);
            this.dishFullNameLabel.TabIndex = 9;
            this.dishFullNameLabel.Text = "Full Name:";
            // 
            // dishDescriptionLabel
            // 
            this.dishDescriptionLabel.AutoSize = true;
            this.dishDescriptionLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishDescriptionLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishDescriptionLabel.Location = new System.Drawing.Point(10, 341);
            this.dishDescriptionLabel.MaximumSize = new System.Drawing.Size(251, 0);
            this.dishDescriptionLabel.Name = "dishDescriptionLabel";
            this.dishDescriptionLabel.Size = new System.Drawing.Size(99, 23);
            this.dishDescriptionLabel.TabIndex = 8;
            this.dishDescriptionLabel.Text = "Description:";
            // 
            // dishPriceTextBox
            // 
            this.dishPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishPriceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishPriceTextBox.Location = new System.Drawing.Point(107, 309);
            this.dishPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishPriceTextBox.Name = "dishPriceTextBox";
            this.dishPriceTextBox.ReadOnly = true;
            this.dishPriceTextBox.Size = new System.Drawing.Size(120, 27);
            this.dishPriceTextBox.TabIndex = 7;
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishPriceLabel.Location = new System.Drawing.Point(10, 312);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(51, 23);
            this.dishPriceLabel.TabIndex = 6;
            this.dishPriceLabel.Text = "Price:";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.PeachPuff;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeButton.Location = new System.Drawing.Point(207, 535);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 55);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProductButton.Location = new System.Drawing.Point(16, 535);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(85, 55);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // dishQuantLabel
            // 
            this.dishQuantLabel.AutoSize = true;
            this.dishQuantLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishQuantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishQuantLabel.Location = new System.Drawing.Point(8, 498);
            this.dishQuantLabel.Name = "dishQuantLabel";
            this.dishQuantLabel.Size = new System.Drawing.Size(78, 23);
            this.dishQuantLabel.TabIndex = 3;
            this.dishQuantLabel.Text = "Quantity:";
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishNameLabel.Location = new System.Drawing.Point(8, 117);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(251, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(81, 30);
            this.dishNameLabel.TabIndex = 1;
            this.dishNameLabel.Text = "Name:";
            // 
            // categoryButtonPanel
            // 
            this.categoryButtonPanel.Location = new System.Drawing.Point(0, 37);
            this.categoryButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryButtonPanel.Name = "categoryButtonPanel";
            this.categoryButtonPanel.Size = new System.Drawing.Size(392, 314);
            this.categoryButtonPanel.TabIndex = 4;
            // 
            // billPanel
            // 
            this.billPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.billPanel.Controls.Add(this.orderCreateButton);
            this.billPanel.Controls.Add(this.dataOrderGridView);
            this.billPanel.Controls.Add(this.tableTextBox);
            this.billPanel.Controls.Add(this.totalBillLabel);
            this.billPanel.Controls.Add(this.changeButton);
            this.billPanel.Controls.Add(this.totalLabel);
            this.billPanel.Controls.Add(this.tableNrLabel);
            this.billPanel.Controls.Add(this.billLabel);
            this.billPanel.Location = new System.Drawing.Point(708, 33);
            this.billPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(566, 599);
            this.billPanel.TabIndex = 5;
            // 
            // orderCreateButton
            // 
            this.orderCreateButton.BackColor = System.Drawing.Color.GreenYellow;
            this.orderCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderCreateButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCreateButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderCreateButton.Location = new System.Drawing.Point(476, 535);
            this.orderCreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderCreateButton.Name = "orderCreateButton";
            this.orderCreateButton.Size = new System.Drawing.Size(85, 55);
            this.orderCreateButton.TabIndex = 19;
            this.orderCreateButton.Text = "CREATE";
            this.orderCreateButton.UseVisualStyleBackColor = false;
            this.orderCreateButton.Click += new System.EventHandler(this.orderCreateButton_Click);
            // 
            // dataOrderGridView
            // 
            this.dataOrderGridView.AllowUserToAddRows = false;
            this.dataOrderGridView.AllowUserToDeleteRows = false;
            this.dataOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrderGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.quantity,
            this.price});
            this.dataOrderGridView.Location = new System.Drawing.Point(5, 110);
            this.dataOrderGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataOrderGridView.Name = "dataOrderGridView";
            this.dataOrderGridView.ReadOnly = true;
            this.dataOrderGridView.RowHeadersWidth = 51;
            this.dataOrderGridView.RowTemplate.Height = 24;
            this.dataOrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderGridView.Size = new System.Drawing.Size(556, 353);
            this.dataOrderGridView.TabIndex = 14;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 74;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tableTextBox
            // 
            this.tableTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTextBox.Location = new System.Drawing.Point(432, 41);
            this.tableTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.ReadOnly = true;
            this.tableTextBox.Size = new System.Drawing.Size(120, 30);
            this.tableTextBox.TabIndex = 11;
            this.tableTextBox.Text = "Not Selected";
            this.tableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalBillLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totalBillLabel.Location = new System.Drawing.Point(471, 494);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(71, 30);
            this.totalBillLabel.TabIndex = 13;
            this.totalBillLabel.Text = "00,00";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Tomato;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.changeButton.Location = new System.Drawing.Point(468, 72);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(84, 34);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totalLabel.Location = new System.Drawing.Point(373, 493);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(79, 32);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // tableNrLabel
            // 
            this.tableNrLabel.AutoSize = true;
            this.tableNrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tableNrLabel.Location = new System.Drawing.Point(346, 44);
            this.tableNrLabel.Name = "tableNrLabel";
            this.tableNrLabel.Size = new System.Drawing.Size(79, 23);
            this.tableNrLabel.TabIndex = 4;
            this.tableNrLabel.Text = "Table Nr.";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.billLabel.Location = new System.Drawing.Point(8, 9);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(69, 38);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Bill ";
            // 
            // dataDishGridView
            // 
            this.dataDishGridView.AllowUserToAddRows = false;
            this.dataDishGridView.AllowUserToDeleteRows = false;
            this.dataDishGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDishGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDishGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDishGridView.Location = new System.Drawing.Point(12, 356);
            this.dataDishGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDishGridView.MultiSelect = false;
            this.dataDishGridView.Name = "dataDishGridView";
            this.dataDishGridView.ReadOnly = true;
            this.dataDishGridView.RowHeadersWidth = 51;
            this.dataDishGridView.RowTemplate.Height = 24;
            this.dataDishGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDishGridView.Size = new System.Drawing.Size(380, 276);
            this.dataDishGridView.TabIndex = 9;
            this.dataDishGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDishGridView_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1282, 30);
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
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1282, 643);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataDishGridView);
            this.Controls.Add(this.billPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.categoryButtonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSi - New Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishQuantityUpDown)).EndInit();
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel infoPanel;
		private System.Windows.Forms.Panel categoryButtonPanel;
		private System.Windows.Forms.Panel billPanel;
		private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label dishQuantLabel;
        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.TextBox dishPriceTextBox;
        private System.Windows.Forms.Label dishPriceLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label tableNrLabel;
        private System.Windows.Forms.Label dishDescriptionLabel;
        private System.Windows.Forms.Label dishFullNameLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.DataGridView dataDishGridView;
        private System.Windows.Forms.TextBox dishNameTextBox;
        private System.Windows.Forms.TextBox dishDescTextBox;
        private System.Windows.Forms.TextBox dishFullNameTextBox;
        private System.Windows.Forms.TextBox dishIDTextBox;
        private System.Windows.Forms.Label dishIDLabel;
        private System.Windows.Forms.DataGridView dataOrderGridView;
        private System.Windows.Forms.NumericUpDown dishQuantityUpDown;
        private System.Windows.Forms.Button orderCreateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label dishInfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}