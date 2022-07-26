using System;
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
        int s_category_id = 0;

        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public NewOrderForm()
		{
			InitializeComponent();
		}
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            Forms.OrderTableForm table = new Forms.OrderTableForm();
            table.ShowDialog();
            tableTextBox.Text = OrderClass.orderTableNr.ToString();
            loadCategoryButtons();
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void clearData()
        {
            dishIDTextBox.Text = "";
            dishNameTextBox.Text = "";
            dishFullNameTextBox.Text = "";
            dishPriceTextBox.Text = "";
            dishDescTextBox.Text = "";
            dishQuantityUpDown.Value = 1;
        }

        private void loadCategoryButtons()
        {
            try
            {
                // count buttons
                int counter = 0;
                Point buttonPoint = new Point(-70, 0);
                string query = "select * from [Category]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Button categoryButton = new Button();
                    categoryButton.Size = new Size(70, 40);
                    categoryButton.Font = new Font("Malgun Gothic", 8, FontStyle.Regular);
                    categoryButton.FlatStyle = FlatStyle.Flat;
                    if (counter == 3)
                    {
                        // next line
                        buttonPoint = new Point(buttonPoint.X - 225, buttonPoint.Y + 45);
                        counter = 0;
                    }
                    categoryButton.Location = new Point(buttonPoint.X + 75, buttonPoint.Y);
                    categoryButton.Name = "category" + row["name"] + "Button";
                    categoryButton.Text = row["name"].ToString();
                    categoryButtonPanel.Controls.Add(categoryButton);
                    buttonPoint = categoryButton.Location;
                    counter++;

                    categoryButton.Click += new EventHandler(this.categoryButtonClick);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadDishDataGridView()
        {
            clearData();
            dataDishGridView.Rows.Clear();
            dataDishGridView.Refresh();
            string query = "select Dish.* from [Dish] join Dish_Category on Dish.id = Dish_Category.dish_id join Category on Dish_Category.category_id = Category.id where category_id = " + s_category_id;
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataDishGridView.ColumnCount = 3;
            dataDishGridView.Columns[0].Name = "ID";
            dataDishGridView.Columns[1].Name = "Name";
            dataDishGridView.Columns[2].Name = "Price";

            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[] 
                    { row["id"].ToString(), row["name"].ToString(), row["price"].ToString() };
                dataDishGridView.Rows.Add(dataGridViewRow);
            }

            conn.Close();
        }

        private void categoryButtonClick(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            try
            {
                string query = "select * from [Category] where name = '" + buttonClick.Text + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    s_category_id = int.Parse(row["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDishDataGridView();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to change the table number?", "Change New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                tableTextBox.Text = "";
                Forms.OrderTableForm table = new Forms.OrderTableForm();
                table.ShowDialog();
                tableTextBox.Text = OrderClass.orderTableNr.ToString();
            }
        }

        private void dataDishGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            dishQuantityUpDown.Value = 1;
            int id = int.Parse(dataDishGridView.CurrentRow.Cells["id"].Value.ToString());
            string query = "select * from [Dish] where id = " + id;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dishIDTextBox.Text = reader["id"].ToString();
                dishNameTextBox.Text = reader["name"].ToString();
                dishFullNameTextBox.Text = reader["full_name"].ToString();
                dishPriceTextBox.Text = reader["price"].ToString();
                dishDescTextBox.Text = reader["description"].ToString();
            }
            conn.Close();
        }

        private void dishQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataDishGridView.CurrentRow.Cells["id"].Value.ToString());
                int rowIndex = dataDishGridView.CurrentCell.RowIndex;
                int quantity = (int)dishQuantityUpDown.Value;
                int price = int.Parse(dataDishGridView.Rows[rowIndex].Cells["price"].Value.ToString()); 
                dishPriceTextBox.Text = (quantity * price).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (dishIDTextBox.Text != "" && dishNameTextBox.Text != "" && dishPriceTextBox.Text != "")
            {
                try
                {
                    int dish_id = int.Parse(dishIDTextBox.Text);
                    dataOrderGridView.ColumnCount = 4;
                    dataOrderGridView.Columns[0].Name = "ID";
                    dataOrderGridView.Columns[1].Name = "Name";
                    dataOrderGridView.Columns[2].Name = "Quantity";
                    dataOrderGridView.Columns[3].Name = "Price";

                    int rowIndex = dataOrderGridView.Rows.Add();
                    DataGridViewRow gridViewRow = dataOrderGridView.Rows[rowIndex];
                    gridViewRow.Cells["id"].Value = dishIDTextBox.Text;
                    gridViewRow.Cells["name"].Value = dishNameTextBox.Text;
                    gridViewRow.Cells["quantity"].Value = dishQuantityUpDown.Value;
                    gridViewRow.Cells["price"].Value = dishPriceTextBox.Text;

                    for (int curRow = 0; curRow < dataOrderGridView.RowCount - 1; curRow++)
                    {
                        var Row = dataOrderGridView.Rows[curRow];
                        int id = Convert.ToInt32(Row.Cells["id"].Value);
                        for (int row = curRow + 1; row < dataOrderGridView.RowCount; row++)
                        {
                            var Row2 = dataOrderGridView.Rows[row];
                            int idCompare = Convert.ToInt32(Row2.Cells["id"].Value);
                            if (id == idCompare)
                            {
                                Row.Cells["quantity"].Value = Convert.ToInt32(Row.Cells["quantity"].Value) + Convert.ToInt32(Row2.Cells["quantity"].Value);
                                Row.Cells["price"].Value = Convert.ToDecimal(Row.Cells["price"].Value) + Convert.ToDecimal(Row2.Cells["price"].Value); // price
                                dataOrderGridView.Rows.Remove(Row2);
                                row--;
                            }
                        }
                    }

                    double sum = 0;
                    for (int i = 0; i < dataOrderGridView.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(dataOrderGridView.Rows[i].Cells["price"].Value);
                    }
                    totalBillLabel.Text = sum.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have not chosen a dish.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataOrderGridView.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow item in dataOrderGridView.SelectedRows)
                    {
                        dataOrderGridView.Rows.RemoveAt(item.Index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a dish to remove.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int orderCreate() 
        {
            SqlCommand command = new SqlCommand("[sp_create_order]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_table_nr", tableTextBox.Text);
            command.Parameters.AddWithValue("@p_datetime", DateTime.Now);
            command.Parameters.AddWithValue("@p_user_id", MyUserClass.userId);
            command.Parameters.AddWithValue("@p_isActive", 1);
            command.Parameters.AddWithValue("@p_price", decimal.Parse(totalBillLabel.Text));

            command.Parameters.Add("@order_id", System.Data.SqlDbType.SmallInt).Direction = System.Data.ParameterDirection.ReturnValue;
            
            conn.Open();
            command.ExecuteNonQuery();
            int retval = (int)command.Parameters["@order_id"].Value;
            conn.Close();
            return retval;
        }

        private void dishAddToOrder(int orderID)
        {
            // fill DataTable
            DataTable table = new DataTable();
            foreach (DataGridViewColumn column in dataOrderGridView.Columns)
                table.Columns.Add(column.HeaderText);
            foreach (DataGridViewRow row in dataOrderGridView.Rows)
            {
                table.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.Rows[table.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            string query2 = "insert into [Order_Dish](order_id, dish_id, quantity) values(@order_id, @dish_id, @quantity)";
            SqlCommand command1 = new SqlCommand(query2, conn);
            // add value in db
            foreach (DataRow row in table.Rows)
            {
                conn.Open();
                command1.Parameters.AddWithValue("@order_id", orderID);
                command1.Parameters.AddWithValue("@dish_id", row["id"]);
                command1.Parameters.AddWithValue("@quantity", row["quantity"]);
                command1.ExecuteNonQuery();
                conn.Close();
                command1.Parameters.Clear();
            }
        }

        private void orderCreateButton_Click(object sender, EventArgs e)
        {
            if (dataOrderGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Create an order?", "Create Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        int orderID = orderCreate();
                        OrderClass.orderId = orderID;
                        dishAddToOrder(orderID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Order is created", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Forms.PaymentForm payment = new Forms.PaymentForm();
                        //payment.Show();
                        //this.Hide();
                        Forms.OrdersForm orders = new Forms.OrdersForm();
                        orders.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot create an empty order.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }
    }
}
