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
    public partial class PaymentForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            int orderID = int.Parse(OrderClass.orderId.ToString());
            orderIDTextBox.Text = orderID.ToString();
            loadPMethodsComboBox();
            loadItems(orderID);
        }

        private void loadPMethodsComboBox()
        {
            try
            {
                string query = "SELECT id, name FROM [PaymentMethod]";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                paymentTypeComboBox.DataSource = table;
                paymentTypeComboBox.DisplayMember = "name";
                paymentTypeComboBox.ValueMember = "id";
                paymentTypeComboBox.Enabled = true;
                
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadItems(int orderID)
        {
            try
            {
                dataPriceGridView.Rows.Clear();

                dataPriceGridView.ColumnCount = 3;
                dataPriceGridView.Columns[0].Name = "Name";
                dataPriceGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataPriceGridView.Columns[1].Name = "Quantity";
                dataPriceGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataPriceGridView.Columns[2].Name = "Price";
                dataPriceGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                conn.Open();
                string query = "[sp_show_dishes_by_order]";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_order_id", orderID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["name"].ToString(), row["quantity"].ToString(), row["price"].ToString() };
                    dataPriceGridView.Rows.Add(dataGridViewRow);
                }
                conn.Close();

                loadOrderPrice(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadOrderPrice(int orderID)
        {
            string query = "SELECT price FROM [Order] WHERE id = @order_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@order_id", orderID);
            conn.Open();
            object result = command.ExecuteScalar();
            decimal resultPrice = decimal.Parse(result.ToString());
            conn.Close();
            orderTotalTextBox.Text = resultPrice.ToString("0.00");
        }

        private void closeOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paymentTypeComboBox.Text))
            {
                MessageBox.Show("Select payment type", "Close Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (orderTotalTextBox.Text != "" || orderReceivedTextBox.Text != "" || orderChangeTextBox.Text != "")
            {
                closeOrder();
                OrderClass.clearData();

                Forms.OrdersForm orders = new Forms.OrdersForm();
                this.Hide();
                orders.Show();
            }
            else
            {
                MessageBox.Show("You can not close this order. Enter amount.", "Close Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeOrder()
        {
            DataRowView dataRow = paymentTypeComboBox.SelectedItem as DataRowView;
            int paymentID = int.Parse(dataRow.Row["id"].ToString());
            SqlCommand command = new SqlCommand("[sp_close_order]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId);
            command.Parameters.AddWithValue("@p_pmethod_id", paymentID);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void calculateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderTotalTextBox.Text != "" && orderReceivedTextBox.Text != "")
                {
                    decimal rec = decimal.Parse(orderReceivedTextBox.Text);
                    decimal tot = decimal.Parse(orderTotalTextBox.Text);
                    if (rec < tot)
                    {
                        MessageBox.Show("Unable to give change.", "Calculate Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    decimal change = rec - tot;
                    orderChangeTextBox.Text = change.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("You can not calculate this order. Enter amount.", "Calculate Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass.orderId = int.Parse(orderIDTextBox.Text);
                Forms.EditOrderForm editOrder = new EditOrderForm();
                this.Hide();
                editOrder.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printBillButton_Click(object sender, EventArgs e)
        {
            Forms.PrintBillForm printBill = new PrintBillForm();
            printBill.ShowDialog();
        }

        private void paymentTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView dataRow = paymentTypeComboBox.SelectedItem as DataRowView;
            string selectItem = dataRow.Row["name"].ToString();
            if (selectItem == "Card")
            {
                orderReceivedLabel.Visible = false;
                orderReceivedTextBox.Visible = false;
                orderChangeLabel.Visible = false;
                orderChangeTextBox.Visible = false;
                calculateOrderButton.Visible = false;

            }
            else
            {
                orderReceivedLabel.Visible = true;
                orderReceivedTextBox.Visible = true;
                orderChangeLabel.Visible = true;
                orderChangeTextBox.Visible = true;
                calculateOrderButton.Visible = true;
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
    }
}
