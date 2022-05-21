﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp
{
	public partial class NewOrderForm : Form
	{
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        SqlDataAdapter adapter;

        public NewOrderForm()
		{
			InitializeComponent();
		}
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();

            adapter = new SqlDataAdapter("select top 1 id from [Order] order by id desc", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                int id = int.Parse(row["id"].ToString()) + 1;

                orderLabel.Text = id.ToString();
            }
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit? NewOrderForm", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void starterButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 1", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void breakfastButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [DishCategory] category on dish.category_id = category.id where category.id = 2", conn);
            adapter.Fill(table);

            for(int i=0; i<table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }

        }

        private void mainsButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 3", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void seaButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 4", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void vegeButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 5", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void snacksButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 6", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void dessertButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 7", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            productsListView.View = View.Details;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("select * from [Dish] dish inner join [Category] category on dish.category_id = category.id where category.id = 8", conn);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["price"].ToString());
                productsListView.Items.Add(item);
            }
        }

        private void productsListView_MouseClick(object sender, MouseEventArgs e)
        {
            quantityTextBox.Text = "1";
            quantityTextBox.Enabled = true;
            int id = int.Parse(productsListView.SelectedItems[0].SubItems[0].Text);
            string query = "select * from Dish where id = " + id;
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string fullName = row["full_name"].ToString();
                string price = row["price"].ToString();
                string description = row["description"].ToString();

                productNameLabel.Text = name;
                fullProductNameLabel.Text = "Full Name: " + fullName;
                priceTextBox.Text = price;
                descriptionLabel.Text = "Description: " + description;
            }
        }

        private void tableNrComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if ((MessageBox.Show("Are you sure you are ordering for table number " + tableNrComboBox.Text + "?", "Create New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            //{
            //    tableNrComboBox.Enabled = false;
            //}

            //DataTable table = new DataTable();
            //adapter = new SqlDataAdapter("select * from [Order] where table_nr = " + tableNrComboBox.Text, conn);
            

            //foreach (DataRow row in table.Rows)
            //{
            //    if (adapter != null)
            //    {
            //        adapter.Fill(table);
            //        int status = int.Parse(row["status"].ToString());
                    
            //        if (status != 0)
            //        {
            //            MessageBox.Show("This table is already in service.", "Create New Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
                
            //}
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to change the table number " + tableNrComboBox.Text + "?", "Change New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                tableNrComboBox.Enabled = true;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //string queryInsert = "insert into [Order] (table_nr, time, price, user_id, isActive) values(@table_nr, @time, @price, @user_id, @status)";
            //SqlCommand command = new SqlCommand(queryInsert, conn);
            
            //command.Parameters.AddWithValue("@table_nr", tableNrComboBox.Text);
            //command.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm"));
            //command.Parameters.AddWithValue("@price", totalBillLabel.Text);
            //command.Parameters.AddWithValue("@user_id", UserClass.userId);
            //command.Parameters.AddWithValue("@status", 1);
            //command.CommandType = CommandType.Text;
            //int i = command.ExecuteNonQuery();
            //conn.Close();
            //MessageBox.Show("Order #" + orderLabel.Text + " added.", "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //orderListView.View = View.Details;
            //conn.Open();
            //string querySelect = "select * from [Order] where id = " + orderLabel.Text;
            //DataTable table = new DataTable();
            //adapter = new SqlDataAdapter(querySelect, conn);
            //adapter.Fill(table);
            //foreach(DataRow row in table.Rows)
            //{
            //    string id = row["id"].ToString();
            //    string name = row["name"].ToString();
            //    string quantity = row["quantity"].ToString();
            //    string price = row["price"].ToString();

            //    ListViewItem item = new ListViewItem(id);
            //    item.SubItems.Add(name);
            //    item.SubItems.Add(quantity);
            //    item.SubItems.Add(price);

            //    orderListView.Items.Add(item);
            //}
        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            

            string query = "select * from [Order] where table_nr = " + tableNrComboBox.Text;
            adapter = new SqlDataAdapter(query, conn);
            if(adapter == null)
            {
                if ((MessageBox.Show("The order isn't exist. Are you sure you are ordering for table nr " + tableNrComboBox.Text + "?", "Create New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {
                    tableNrComboBox.Enabled = false;

                    // create order in database
                    // string queryAddOrder = "";
                    
                }
            }
            

            
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
