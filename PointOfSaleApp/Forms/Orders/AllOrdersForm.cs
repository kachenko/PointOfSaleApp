using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSaleApp.Forms
{
    public partial class OrdersForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            loadUsersComboBox();
            selectedOrder();
        }

        private void selectedOrder()
        {
            if (OrderClass.orderId != 0)
            {
                dataOrdersGridView.Rows[0].Selected = true;
            }
            else
            {
                string orderID = OrderClass.orderId.ToString();
                int nRowIndex = 0;
                if (orderID != "0")
                {
                    foreach (DataGridViewRow row in dataOrdersGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(orderID))
                        {
                            nRowIndex = row.Index;
                            break;
                        }
                    }
                    dataOrdersGridView.Rows[nRowIndex].Selected = true;
                }
            }
        }

        private void loadUsersComboBox()
        {
            try
            {
                string query = "SELECT id, full_name FROM [User]";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                usersComboBox.DataSource = table;
                usersComboBox.DisplayMember = "full_name";
                usersComboBox.ValueMember = "id";
                usersComboBox.Enabled = true;
                var myID = usersComboBox.Items.Cast<Object>()
                    .Where(x => usersComboBox.GetItemText(x).Equals(MyUserClass.userFullName))
                    .FirstOrDefault();
                usersComboBox.SelectedItem = myID;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadOrders(int userID)
        {
            try
            {
                dataOrdersGridView.Rows.Clear();
                dataOrdersGridView.Refresh();
                int isActive = Convert.ToInt32(activeOrdersCheckBox.Checked);
                string query = "SELECT * FROM [Order] WHERE user_id = @user_id AND isActive = @isActive";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@user_id", userID);
                command.Parameters.AddWithValue("@isActive", isActive);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["id"].ToString(), row["table_nr"].ToString(), row["datetime"].ToString(), row["price"].ToString(), row["isActive"].ToString() };
                    dataOrdersGridView.Rows.Add(dataGridViewRow);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem != null)
            {
                DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                loadOrders(int.Parse(dataRow.Row["id"].ToString()));
            }
            dataDishesGridView.Rows.Clear();
            clearData();
        }

        private void activeOrdersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem != null)
            {
                DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                loadOrders(int.Parse(dataRow.Row["id"].ToString()));
            }
        }

        private void dataOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(dataOrdersGridView.CurrentRow.Cells["id"].Value.ToString());
                OrderClass.orderId = id;

                conn.Open();
                string query = "SELECT * FROM [Order] WHERE id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orderIDTextBox.Text = reader["id"].ToString();
                    orderTableTextBox.Text = reader["table_nr"].ToString();
                    orderDateTextBox.Text = reader["datetime"].ToString();
                    orderFullPriceTextBox.Text = reader["price"].ToString();
                    orderIsActiveTextBox.Text = reader["isActive"].ToString();
                    if (Convert.ToBoolean(reader["isActive"].ToString()) == false)
                    {
                        editOrderButton.Enabled = false;
                        orderCloseButton.Enabled = false;
                    }
                    else
                    {
                        editOrderButton.Enabled = true;
                        orderCloseButton.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

                loadDishes(id);
            }
        }

        private void loadDishes(int orderID)
        {
            dataDishesGridView.Rows.Clear();

            conn.Open();
            dataDishesGridView.ColumnCount = 4;
            dataDishesGridView.Columns[0].Name = "ID";
            dataDishesGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataDishesGridView.Columns[1].Name = "Name";
            dataDishesGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDishesGridView.Columns[2].Name = "Quantity";
            dataDishesGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataDishesGridView.Columns[3].Name = "Price";
            dataDishesGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            string query = "select dish_id, d.name, od.quantity, od.quantity * d.price [price] from [Order] o join [Order_Dish] od on o.id = od.order_id join [Dish] d on d.id = od.dish_id where od.order_id = " + orderID;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[]
                    { row["dish_id"].ToString(), row["name"].ToString(), row["quantity"].ToString(), row["price"].ToString() };
                dataDishesGridView.Rows.Add(dataGridViewRow);
            }
            conn.Close();
        }

        private void printBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataOrdersGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataOrdersGridView.Rows[selectedIndex];
                OrderClass.clearData();
                OrderClass.orderId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                OrderClass.orderTableNr = int.Parse(selectedRow.Cells["table_nr"].Value.ToString());
                OrderClass.orderTime = DateTime.Parse(selectedRow.Cells["datetime"].Value.ToString());
                OrderClass.orderPrice = decimal.Parse(selectedRow.Cells["price"].Value.ToString());
                OrderClass.orderIsActive = bool.Parse(selectedRow.Cells["isActive"].Value.ToString());

                Forms.PrintBillForm printBill = new PrintBillForm();
                printBill.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this order now?", "Close Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int selectedIndex = dataOrdersGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataOrdersGridView.Rows[selectedIndex];
                    OrderClass.clearData();
                    OrderClass.orderId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                    OrderClass.orderTableNr = int.Parse(selectedRow.Cells["table_nr"].Value.ToString());
                    OrderClass.orderTime = DateTime.Parse(selectedRow.Cells["datetime"].Value.ToString());
                    OrderClass.orderPrice = decimal.Parse(selectedRow.Cells["price"].Value.ToString());
                    OrderClass.orderIsActive = bool.Parse(selectedRow.Cells["isActive"].Value.ToString());
                    
                    SqlCommand command = new SqlCommand("[sp_whose_order]", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_user_id", MyUserClass.userId);
                    command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId);
                    conn.Open();
                    int result = (int)command.ExecuteScalar();
                    conn.Close();

                    if (result == 1 || OrderClass.orderIsActive == false || MyUserClass.userRole == "Administrator")
                    {
                        Forms.PaymentForm payment = new Forms.PaymentForm();
                        payment.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You cannot close order that was not created by you or that has already been closed.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataOrdersGridView.SelectedRows.Count > 0)
                {
                    OrderClass.clearData();
                    OrderClass.orderId = int.Parse(orderIDTextBox.Text);
                    OrderClass.orderTableNr = int.Parse(orderTableTextBox.Text);
                    OrderClass.orderTime = DateTime.Parse(orderDateTextBox.Text);
                    OrderClass.orderPrice = decimal.Parse(orderFullPriceTextBox.Text);
                    OrderClass.orderIsActive = bool.Parse(orderIsActiveTextBox.Text);
                    DataTable table = new DataTable();
                    foreach (DataGridViewColumn column in dataDishesGridView.Columns) // ID Name Qty Price 
                        table.Columns.Add(column.HeaderText);
                    foreach (DataGridViewRow row in dataDishesGridView.Rows)
                    {
                        table.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.Rows[table.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }

                    foreach (DataRow row in table.Rows)
                    {
                        OrderClass.DishesId.Add(int.Parse(row["id"].ToString()));
                    }

                    Forms.EditOrderForm editOrder = new EditOrderForm();
                    editOrder.ShowDialog();

                    DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                    loadOrders(int.Parse(dataRow.Row["id"].ToString()));
                    dataDishesGridView.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Please select an order first.", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("[sp_delete_order]", conn); 
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId);
                    command.Parameters.AddWithValue("@p_user_id", MyUserClass.userId);
                    int isDelete = command.ExecuteNonQuery();
                    if (isDelete > 0)
                    {
                        MessageBox.Show("Order deleted.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                    MessageBox.Show("Order not deleted - an error occurred.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                dataOrdersGridView.Rows.Clear();
                DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                loadOrders(int.Parse(dataRow.Row["id"].ToString()));
                OrderClass.clearData();
                clearData();
            }
        }

        private void clearData()
        {
            OrderClass.clearData();
            dataDishesGridView.Rows.Clear();
            orderIDTextBox.Text = "";
            orderIsActiveTextBox.Text = "";
            orderDateTextBox.Text = "";
            orderFullPriceTextBox.Text = "";
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
                OrderClass.clearData();
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
