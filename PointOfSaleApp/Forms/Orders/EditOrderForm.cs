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

namespace PointOfSaleApp.Forms
{
    public partial class EditOrderForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        int s_category_id = 0;

        public EditOrderForm()
        {
            InitializeComponent();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            loadCategoryButtons();
            loadOrder();
        }

        private void loadOrder()
        {
            dataOrderGridView.ColumnCount = 4;
            dataOrderGridView.Columns[0].Name = "ID";
            dataOrderGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataOrderGridView.Columns[1].Name = "Name";
            dataOrderGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataOrderGridView.Columns[2].Name = "Quantity";
            dataOrderGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataOrderGridView.Columns[3].Name = "Price";
            dataOrderGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int orderID = OrderClass.orderId;
            int orderTable = OrderClass.orderTableNr;
            decimal price = OrderClass.orderPrice;
            orderIDTextBox.Text = orderID.ToString();
            tableTextBox.Text = orderTable.ToString();
            totalBillLabel.Text = price.ToString("0.00");
            dataOrderGridView.Rows.Clear();
            dataOrderGridView.Refresh();
            string query = "[sp_show_dishes_by_order]";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_order_id", orderID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["id"].ToString(), row["name"].ToString(), row["quantity"].ToString(), row["price"].ToString() };
                    dataOrderGridView.Rows.Add(dataGridViewRow);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL EXCEPTION: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
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
                categoryButton.Name = "category" + row["name"] + "Button";
                categoryButton.Text = row["name"].ToString();
                categoryButtonPanel.Controls.Add(categoryButton);
                buttonPoint = categoryButton.Location;
                counter++;

                categoryButton.Click += new EventHandler(this.categoryButtonClick);
            }
        }

        private void loadDishDataGridView()
        {
            clearData();
            dataDishGridView.Rows.Clear();
            dataDishGridView.Refresh();

            dataDishGridView.ColumnCount = 3;
            dataDishGridView.Columns[0].Name = "ID";
            dataDishGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataDishGridView.Columns[1].Name = "Name";
            dataDishGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDishGridView.Columns[2].Name = "Price";
            dataDishGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string query = "[sp_show_dish_by_category]";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_category_id", s_category_id);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["id"].ToString(), row["name"].ToString(), row["price"].ToString() };
                    dataDishGridView.Rows.Add(dataGridViewRow);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL EXCEPTION: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void categoryButtonClick(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            try
            {
                string query = "SELECT * FROM [Category] WHERE name = @name";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = buttonClick.Text;
                s_category_id = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            loadDishDataGridView();
        }

        private void dataDishGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dishQuantityUpDown.Value = 1;
            int id = int.Parse(dataDishGridView.CurrentRow.Cells["id"].Value.ToString());
            string query = "SELECT * FROM [Dish] WHERE id = " + id;
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dishIDTextBox.Text = reader["id"].ToString();
                    dishNameTextBox.Text = reader["name"].ToString();
                    dishFullNameTextBox.Text = reader["full_name"].ToString();
                    dishPriceTextBox.Text = reader["price"].ToString();
                    dishDescTextBox.Text = reader["description"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL EXCEPTION: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (dishIDTextBox.Text != "" && dishNameTextBox.Text != "" && dishPriceTextBox.Text != "")
            {
                try
                {
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

        private void dishQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataDishGridView.CurrentRow.Cells["id"].Value.ToString());
                int rowIndex = dataDishGridView.CurrentCell.RowIndex;
                int quantity = (int)dishQuantityUpDown.Value;
                decimal price = decimal.Parse(dataDishGridView.Rows[rowIndex].Cells["price"].Value.ToString());
                dishPriceTextBox.Text = (quantity * price).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("You have not selected a dish to remove.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void dishEditOrder(int orderID)
        {
            if (tableTextBox.Text == "Not Selected" || tableTextBox.Text == "")
            {
                MessageBox.Show("You should select a table number.", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                updateOrder();
                updateOrderDish(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateOrder()
        {
            decimal totalPrice = decimal.Parse(totalBillLabel.Text);
            int tableNr = int.Parse(tableTextBox.Text);
            string query = "[sp_update_order_base]";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_id", OrderClass.orderId);
                command.Parameters.AddWithValue("@p_price", totalPrice);
                command.Parameters.AddWithValue("@p_table_nr", tableNr);
                conn.Open();
                command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL EXCEPTION: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void updateOrderDish(int orderID)
        {
            dishesToInsert(OrderClass.DishesId, orderID);
            dishesToDelete(OrderClass.DishesId, orderID);
        }

        private void dishesToInsert(List<int> oldListDishId, int orderID)
        {
            List<int> newListDishId = new List<int>();

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

            foreach (DataRow row in table.Rows)
                newListDishId.Add(int.Parse(row["id"].ToString()));

            List<int> listToInsert = new List<int>();
            foreach (int i in newListDishId)
            {
                if (!oldListDishId.Any(s => s == i))
                {
                    listToInsert.Add(i);
                }
            }

            if (listToInsert.Count <= 0)
                return;

            foreach (DataRow row in table.Rows)
            {
                SqlCommand command = new SqlCommand("[sp_update_order]", conn);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    command.Parameters.AddWithValue("@p_order_id", orderID);
                    command.Parameters.AddWithValue("@p_dish_id", row["id"]);
                    command.Parameters.AddWithValue("@p_quantity", row["quantity"]);
                    conn.Open();
                    command.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL EXCEPTION: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    command.Parameters.Clear();
                }
            }
        }

        private void dishesToDelete(List<int> oldListDishId, int orderID)
        {
            List<int> newListDishId = new List<int>();
            List<int> listToDelete = new List<int>();

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

            foreach (DataRow row in table.Rows)
                newListDishId.Add(int.Parse(row["id"].ToString()));

            foreach (int i in oldListDishId)
            {
                if (!newListDishId.Any(s => s == i))
                {
                    listToDelete.Add(i);
                }
            }

            if (listToDelete.Count <= 0)
                return;

            string query = "DELETE FROM [Order_Dish] WHERE order_id = @order_id AND dish_id = @dish_id";
            foreach (int dish_id in listToDelete)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    command.Parameters.AddWithValue("@order_id", orderID);
                    command.Parameters.AddWithValue("@dish_id", dish_id);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL EXCEPTION: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    command.Parameters.Clear();
                }
            }
        }

        private void orderSaveButton_Click(object sender, EventArgs e)
        {
            if (dataOrderGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to save order?", "Edit Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    dishEditOrder(OrderClass.orderId);
                    MessageBox.Show("Order edited.", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OrderClass.clearData();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("You cannot create an empty order.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                OrdersForm orders = new OrdersForm();
                orders.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
            }
        }
    }
}
