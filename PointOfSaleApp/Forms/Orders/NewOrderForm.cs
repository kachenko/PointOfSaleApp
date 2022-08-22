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

        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public NewOrderForm()
		{
			InitializeComponent();
		}
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                OrderClass.clearData();
                Forms.OrderTableForm table = new Forms.OrderTableForm();
                table.ShowDialog();
                tableTextBox.Text = OrderClass.orderTableNr.ToString();
                loadCategoryButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string query = "SELECT * FROM [Category]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Button categoryButton = new Button();
                    categoryButton.Size = new Size(80, 40);
                    categoryButton.Font = new Font("Malgun Gothic", 8, FontStyle.Regular);
                    categoryButton.FlatStyle = FlatStyle.Flat;
                    if (counter == 3)
                    {
                        // next line
                        buttonPoint = new Point(buttonPoint.X - 255, buttonPoint.Y + 45);
                        counter = 0;
                    }
                    categoryButton.Location = new Point(buttonPoint.X + 85, buttonPoint.Y);
                    categoryButton.Name = row["name"].ToString();
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
            string query = "[sp_show_dish_by_category]";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_category_id", s_category_id);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataDishGridView.ColumnCount = 3;
            dataDishGridView.Columns[0].Name = "ID";
            dataDishGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataDishGridView.Columns[1].Name = "Name";
            dataDishGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDishGridView.Columns[2].Name = "Price";
            dataDishGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                string query = "SELECT id FROM [Category] WHERE name = @name";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = buttonClick.Text;
                s_category_id = int.Parse(command.ExecuteScalar().ToString());
                conn.Close();
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
                tableTextBox.Text = "Not Selected";
                Forms.OrderTableForm table = new Forms.OrderTableForm();
                table.ShowDialog();
                tableTextBox.Text = OrderClass.orderTableNr.ToString();
            }
        }

        private void dataDishGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            dishQuantityUpDown.Value = 1;
            int id = int.Parse(dataDishGridView.CurrentRow.Cells[0].Value.ToString());
            string query = "SELECT * FROM [Dish] WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
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
                int rowIndex = dataDishGridView.CurrentCell.RowIndex;
                int quantity = int.Parse(dishQuantityUpDown.Value.ToString());
                decimal price = decimal.Parse(dataDishGridView.Rows[rowIndex].Cells["price"].Value.ToString()); 
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
                    OrderClass.DishesId.Add(dish_id);

                    dataOrderGridView.ColumnCount = 4;
                    dataOrderGridView.Columns[0].Name = "ID";
                    dataOrderGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataOrderGridView.Columns[1].Name = "Name";
                    dataOrderGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataOrderGridView.Columns[2].Name = "Quantity";
                    dataOrderGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dataOrderGridView.Columns[3].Name = "Price";
                    dataOrderGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

                    decimal sum = 0;
                    for (int i = 0; i < dataOrderGridView.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataOrderGridView.Rows[i].Cells["price"].Value);
                    }
                    totalBillLabel.Text = sum.ToString("0.00");
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
                    int dish_id = 0;
                    foreach (DataGridViewRow item in dataOrderGridView.SelectedRows)
                    {
                        dish_id = int.Parse(item.Cells[0].Value.ToString());
                        OrderClass.DishesId.Remove(dish_id);
                        dataOrderGridView.Rows.RemoveAt(item.Index);
                    }

                    decimal sum = 0;
                    for (int i = 0; i < dataOrderGridView.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataOrderGridView.Rows[i].Cells["price"].Value);
                    }
                    totalBillLabel.Text = sum.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a dish to remove.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int orderCreate() 
        {
            int tableNr = int.Parse(tableTextBox.Text);
            DateTime dateTime = DateTime.Now;
            int userId = MyUserClass.userId;
            bool isActive = true;
            decimal orderPrice = decimal.Parse(totalBillLabel.Text);

            SqlCommand command = new SqlCommand("[sp_create_order]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_table_nr", tableNr);
            command.Parameters.AddWithValue("@p_datetime", dateTime);
            command.Parameters.AddWithValue("@p_user_id", userId);
            command.Parameters.AddWithValue("@p_isActive", isActive);
            command.Parameters.AddWithValue("@p_price", orderPrice);

            command.Parameters.Add("@order_id", System.Data.SqlDbType.SmallInt).Direction =
                System.Data.ParameterDirection.ReturnValue;

            conn.Open();
            command.ExecuteNonQuery();
            int retval = (int)command.Parameters["@order_id"].Value;
            conn.Close();

            OrderClass.orderId = retval;
            OrderClass.orderTableNr = tableNr;
            OrderClass.orderTime = dateTime;
            OrderClass.orderPrice = orderPrice;
            OrderClass.orderIsActive = isActive;
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

            string query = "[sp_insert_dish_to_order]";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;
            // add value in db
            foreach (DataRow row in table.Rows)
            {
                conn.Open();
                command.Parameters.AddWithValue("@p_order_id", orderID);
                command.Parameters.AddWithValue("@p_dish_id", row["id"]);
                command.Parameters.AddWithValue("@p_quantity", row["quantity"]);
                command.ExecuteNonQuery();
                conn.Close();
                command.Parameters.Clear();
            }
        }

        private void orderCreateButton_Click(object sender, EventArgs e)
        {
            if (tableTextBox.Text == "Not Selected")
            {
                MessageBox.Show("You should select a table number.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataOrderGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Create an order?", "Create Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int orderID = 0;
                    try
                    {
                        orderID = orderCreate();
                        dishAddToOrder(orderID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        orderDelete(orderID);
                    }
                    finally
                    {
                        MessageBox.Show("Order is created", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Forms.OrdersForm orders = new Forms.OrdersForm();
                        orders.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot create an empty order.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderDelete(int orderID)
        {
            OrderClass.clearData();
            SqlCommand command = new SqlCommand("[sp_delete_order]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_order_id", orderID);
            command.Parameters.AddWithValue("@p_user_id", MyUserClass.userId);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end your session?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                MyUserClass.ClearMyUser();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to return.\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
