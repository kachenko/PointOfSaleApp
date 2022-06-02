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
    public partial class OrdersForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            loadUsersComboBox();
        }

        private void loadUsersComboBox()
        {
            try
            {
                string query = "select id, full_name from [User]";
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
                string query = "select * from [Order] where user_id = " + userID + " and isActive = " + Convert.ToInt32(activeOrdersCheckBox.Checked);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
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

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem != null)
            {
                DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                loadOrders(int.Parse(dataRow.Row["id"].ToString()));
            }
            dataDishesGridView.Rows.Clear();
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
            try
            {
                int id = int.Parse(dataOrdersGridView.CurrentRow.Cells["id"].Value.ToString());
                OrderClass.orderId = id;

                conn.Open();
                string query = "select * from [Order] where id = " + id;
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orderIDTextBox.Text = reader["id"].ToString();
                    orderTableTextBox.Text = reader["table_nr"].ToString();
                    orderDateTextBox.Text = reader["datetime"].ToString();
                    orderFullPriceTextBox.Text = reader["price"].ToString();
                    orderIsActiveTextBox.Text = reader["isActive"].ToString();
                    if (reader["isActive"].ToString() == "0")
                    {
                        editOrderButton.Enabled = false;
                    }
                    else
                    {
                        editOrderButton.Enabled = true;
                    }
                }
                conn.Close();

                loadDishes(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadDishes(int orderID)
        {
            dataDishesGridView.Rows.Clear();

            conn.Open();
            dataDishesGridView.ColumnCount = 4;
            dataDishesGridView.Columns[0].Name = "ID";
            dataDishesGridView.Columns[1].Name = "Name";
            dataDishesGridView.Columns[2].Name = "Quantity";
            dataDishesGridView.Columns[3].Name = "Price";

            string query = "select * from [Order_Dish] od join [Dish] d on d.id = od.dish_id where od.order_id = " + orderID;
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
            // wydruk paragonu
        }

        private void orderCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this order now?", "Close Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int selectedIndex = dataOrdersGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataOrdersGridView.Rows[selectedIndex];
                    //OrderClass.orderId = int.Parse(selectedRow.Cells["id"].Value.ToString());

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
                // OrderClass.orderId = int.Parse(orderIDTextBox.Text);
                Forms.EditOrderForm editOrder = new EditOrderForm();
                this.Hide();
                editOrder.Show();
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
                    MessageBox.Show("Order not deleted - an error occurred.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();

                    dataOrdersGridView.Rows.Clear();
                    DataRowView dataRow = usersComboBox.SelectedItem as DataRowView;
                    loadOrders(int.Parse(dataRow.Row["id"].ToString()));
                    OrderClass.orderId = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
