
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
            this.components = new System.ComponentModel.Container();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.disgQuantityTextBox = new System.Windows.Forms.TextBox();
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
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.tableNrLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.positLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDBDataSet = new PointOfSaleApp.posDBDataSet();
            this.dishTableAdapter = new PointOfSaleApp.posDBDataSetTableAdapters.DishTableAdapter();
            this.dataDishGridView = new System.Windows.Forms.DataGridView();
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
            this.dishFullNameTextBox = new System.Windows.Forms.TextBox();
            this.dishDescTextBox = new System.Windows.Forms.TextBox();
            this.dishNameTextBox = new System.Windows.Forms.TextBox();
            this.dishIDTextBox = new System.Windows.Forms.TextBox();
            this.dishIDLabel = new System.Windows.Forms.Label();
            this.dataOrderGridView = new System.Windows.Forms.DataGridView();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.billPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.dishIDTextBox);
            this.infoPanel.Controls.Add(this.dishIDLabel);
            this.infoPanel.Controls.Add(this.dishNameTextBox);
            this.infoPanel.Controls.Add(this.dishDescTextBox);
            this.infoPanel.Controls.Add(this.dishFullNameTextBox);
            this.infoPanel.Controls.Add(this.disgQuantityTextBox);
            this.infoPanel.Controls.Add(this.dishFullNameLabel);
            this.infoPanel.Controls.Add(this.dishDescriptionLabel);
            this.infoPanel.Controls.Add(this.dishPriceTextBox);
            this.infoPanel.Controls.Add(this.dishPriceLabel);
            this.infoPanel.Controls.Add(this.addProductButton);
            this.infoPanel.Controls.Add(this.dishQuantLabel);
            this.infoPanel.Controls.Add(this.dishNameLabel);
            this.infoPanel.Location = new System.Drawing.Point(395, 173);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(303, 427);
            this.infoPanel.TabIndex = 7;
            // 
            // disgQuantityTextBox
            // 
            this.disgQuantityTextBox.Enabled = false;
            this.disgQuantityTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disgQuantityTextBox.Location = new System.Drawing.Point(102, 308);
            this.disgQuantityTextBox.Name = "disgQuantityTextBox";
            this.disgQuantityTextBox.Size = new System.Drawing.Size(120, 25);
            this.disgQuantityTextBox.TabIndex = 10;
            this.disgQuantityTextBox.Text = "1";
            // 
            // dishFullNameLabel
            // 
            this.dishFullNameLabel.AutoSize = true;
            this.dishFullNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishFullNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishFullNameLabel.Location = new System.Drawing.Point(4, 75);
            this.dishFullNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
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
            this.dishDescriptionLabel.Location = new System.Drawing.Point(4, 183);
            this.dishDescriptionLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishDescriptionLabel.Name = "dishDescriptionLabel";
            this.dishDescriptionLabel.Size = new System.Drawing.Size(99, 23);
            this.dishDescriptionLabel.TabIndex = 8;
            this.dishDescriptionLabel.Text = "Description:";
            // 
            // dishPriceTextBox
            // 
            this.dishPriceTextBox.Enabled = false;
            this.dishPriceTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishPriceTextBox.Location = new System.Drawing.Point(101, 152);
            this.dishPriceTextBox.Name = "dishPriceTextBox";
            this.dishPriceTextBox.Size = new System.Drawing.Size(120, 25);
            this.dishPriceTextBox.TabIndex = 7;
            this.dishPriceTextBox.Text = "100";
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishPriceLabel.Location = new System.Drawing.Point(4, 154);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(47, 23);
            this.dishPriceLabel.TabIndex = 6;
            this.dishPriceLabel.Text = "Price";
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeButton.Location = new System.Drawing.Point(90, 360);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 55);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.addProductButton.Location = new System.Drawing.Point(7, 363);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(85, 55);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // dishQuantLabel
            // 
            this.dishQuantLabel.AutoSize = true;
            this.dishQuantLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishQuantLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishQuantLabel.Location = new System.Drawing.Point(4, 308);
            this.dishQuantLabel.Name = "dishQuantLabel";
            this.dishQuantLabel.Size = new System.Drawing.Size(74, 23);
            this.dishQuantLabel.TabIndex = 3;
            this.dishQuantLabel.Text = "Quantity";
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishNameLabel.Location = new System.Drawing.Point(3, 39);
            this.dishNameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(75, 30);
            this.dishNameLabel.TabIndex = 1;
            this.dishNameLabel.Text = "Name";
            // 
            // categoryButtonPanel
            // 
            this.categoryButtonPanel.Location = new System.Drawing.Point(0, 33);
            this.categoryButtonPanel.Name = "categoryButtonPanel";
            this.categoryButtonPanel.Size = new System.Drawing.Size(393, 317);
            this.categoryButtonPanel.TabIndex = 4;
            // 
            // billPanel
            // 
            this.billPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.billPanel.Controls.Add(this.dataOrderGridView);
            this.billPanel.Controls.Add(this.tableTextBox);
            this.billPanel.Controls.Add(this.totalBillLabel);
            this.billPanel.Controls.Add(this.changeButton);
            this.billPanel.Controls.Add(this.totalLabel);
            this.billPanel.Controls.Add(this.printButton);
            this.billPanel.Controls.Add(this.tableNrLabel);
            this.billPanel.Controls.Add(this.billLabel);
            this.billPanel.Controls.Add(this.removeButton);
            this.billPanel.Location = new System.Drawing.Point(704, 173);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(278, 427);
            this.billPanel.TabIndex = 5;
            // 
            // tableTextBox
            // 
            this.tableTextBox.Enabled = false;
            this.tableTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTextBox.Location = new System.Drawing.Point(129, 30);
            this.tableTextBox.Name = "tableTextBox";
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
            this.totalBillLabel.Location = new System.Drawing.Point(221, 327);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(45, 30);
            this.totalBillLabel.TabIndex = 13;
            this.totalBillLabel.Text = "0.0";
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeButton.Location = new System.Drawing.Point(166, 70);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(84, 35);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totalLabel.Location = new System.Drawing.Point(3, 332);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(72, 30);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // printButton
            // 
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printButton.Location = new System.Drawing.Point(181, 360);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(85, 55);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // tableNrLabel
            // 
            this.tableNrLabel.AutoSize = true;
            this.tableNrLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNrLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tableNrLabel.Location = new System.Drawing.Point(4, 33);
            this.tableNrLabel.Name = "tableNrLabel";
            this.tableNrLabel.Size = new System.Drawing.Size(79, 23);
            this.tableNrLabel.TabIndex = 4;
            this.tableNrLabel.Text = "Table Nr.";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.billLabel.Location = new System.Drawing.Point(3, 0);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(67, 30);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Bill #";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.orderIDTextBox);
            this.mainPanel.Controls.Add(this.orderIDLabel);
            this.mainPanel.Controls.Add(this.positLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.userPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(395, 33);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(575, 137);
            this.mainPanel.TabIndex = 6;
            // 
            // positLabel
            // 
            this.positLabel.AutoSize = true;
            this.positLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.positLabel.Location = new System.Drawing.Point(120, 40);
            this.positLabel.Name = "positLabel";
            this.positLabel.Size = new System.Drawing.Size(70, 23);
            this.positLabel.TabIndex = 2;
            this.positLabel.Text = "Position";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameLabel.Location = new System.Drawing.Point(118, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(179, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name Surname";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::PointOfSaleApp.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(3, 3);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(111, 130);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.posDBDataSet;
            // 
            // posDBDataSet
            // 
            this.posDBDataSet.DataSetName = "posDBDataSet";
            this.posDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // dataDishGridView
            // 
            this.dataDishGridView.AllowUserToAddRows = false;
            this.dataDishGridView.AllowUserToDeleteRows = false;
            this.dataDishGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDishGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDishGridView.Location = new System.Drawing.Point(0, 356);
            this.dataDishGridView.MultiSelect = false;
            this.dataDishGridView.Name = "dataDishGridView";
            this.dataDishGridView.ReadOnly = true;
            this.dataDishGridView.RowHeadersWidth = 51;
            this.dataDishGridView.RowTemplate.Height = 24;
            this.dataDishGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDishGridView.Size = new System.Drawing.Size(392, 244);
            this.dataDishGridView.TabIndex = 9;
            this.dataDishGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDishGridView_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 42;
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
            // dishFullNameTextBox
            // 
            this.dishFullNameTextBox.Enabled = false;
            this.dishFullNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishFullNameTextBox.Location = new System.Drawing.Point(101, 75);
            this.dishFullNameTextBox.Multiline = true;
            this.dishFullNameTextBox.Name = "dishFullNameTextBox";
            this.dishFullNameTextBox.Size = new System.Drawing.Size(196, 71);
            this.dishFullNameTextBox.TabIndex = 12;
            this.dishFullNameTextBox.Text = "Not Selected";
            this.dishFullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dishDescTextBox
            // 
            this.dishDescTextBox.Enabled = false;
            this.dishDescTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishDescTextBox.Location = new System.Drawing.Point(101, 183);
            this.dishDescTextBox.Multiline = true;
            this.dishDescTextBox.Name = "dishDescTextBox";
            this.dishDescTextBox.Size = new System.Drawing.Size(196, 93);
            this.dishDescTextBox.TabIndex = 13;
            this.dishDescTextBox.Text = "Not Selected";
            this.dishDescTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dishNameTextBox
            // 
            this.dishNameTextBox.Enabled = false;
            this.dishNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishNameTextBox.Location = new System.Drawing.Point(101, 39);
            this.dishNameTextBox.Name = "dishNameTextBox";
            this.dishNameTextBox.Size = new System.Drawing.Size(120, 30);
            this.dishNameTextBox.TabIndex = 14;
            this.dishNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dishIDTextBox
            // 
            this.dishIDTextBox.Enabled = false;
            this.dishIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishIDTextBox.Location = new System.Drawing.Point(101, 7);
            this.dishIDTextBox.Name = "dishIDTextBox";
            this.dishIDTextBox.Size = new System.Drawing.Size(62, 25);
            this.dishIDTextBox.TabIndex = 16;
            // 
            // dishIDLabel
            // 
            this.dishIDLabel.AutoSize = true;
            this.dishIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dishIDLabel.Location = new System.Drawing.Point(4, 7);
            this.dishIDLabel.Name = "dishIDLabel";
            this.dishIDLabel.Size = new System.Drawing.Size(26, 23);
            this.dishIDLabel.TabIndex = 15;
            this.dishIDLabel.Text = "ID";
            // 
            // dataOrderGridView
            // 
            this.dataOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderGridView.Location = new System.Drawing.Point(3, 111);
            this.dataOrderGridView.Name = "dataOrderGridView";
            this.dataOrderGridView.RowHeadersWidth = 51;
            this.dataOrderGridView.RowTemplate.Height = 24;
            this.dataOrderGridView.Size = new System.Drawing.Size(272, 213);
            this.dataOrderGridView.TabIndex = 14;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Enabled = false;
            this.orderIDTextBox.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(510, 8);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(62, 25);
            this.orderIDTextBox.TabIndex = 18;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIDLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orderIDLabel.Location = new System.Drawing.Point(429, 8);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(75, 23);
            this.orderIDLabel.TabIndex = 17;
            this.orderIDLabel.Text = "Order ID";
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataDishGridView);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.billPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.categoryButtonPanel);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - New Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDishGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel infoPanel;
		private System.Windows.Forms.Panel categoryButtonPanel;
		private System.Windows.Forms.Panel billPanel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label positLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.PictureBox userPictureBox;
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
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.TextBox disgQuantityTextBox;
        private System.Windows.Forms.TextBox tableTextBox;
        private posDBDataSet posDBDataSet;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private posDBDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        private System.Windows.Forms.DataGridView dataDishGridView;
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
        private System.Windows.Forms.TextBox dishNameTextBox;
        private System.Windows.Forms.TextBox dishDescTextBox;
        private System.Windows.Forms.TextBox dishFullNameTextBox;
        private System.Windows.Forms.TextBox dishIDTextBox;
        private System.Windows.Forms.Label dishIDLabel;
        private System.Windows.Forms.DataGridView dataOrderGridView;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Label orderIDLabel;
    }
}