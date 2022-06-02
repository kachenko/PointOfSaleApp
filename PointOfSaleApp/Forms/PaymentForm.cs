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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            orderIDTextBox.Text = OrderClass.orderId.ToString();
            loadPMethodsComboBox();
            loadItems(OrderClass.orderId);
        }

        private void loadPMethodsComboBox()
        {
            try
            {
                string query = "select id, name from [PaymentMethod]";
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
                dataPriceGridView.Refresh();

                conn.Open();
                string query = "select * from [Order_Dish] od left join [Dish] d on od.dish_id = d.id where order_id = " + orderID;
                SqlCommand command = new SqlCommand(query, conn);
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

                decimal amount = 0;
                foreach (DataRow row in table.Rows)
                {
                    amount += decimal.Parse(row["price"].ToString());
                }
                orderTotalTextBox.Text = amount.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paymentTypeComboBox.Text))
            {
                MessageBox.Show("Select payment type", "Close Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (orderTotalTextBox.Text != "" || orderReceivedTextBox.Text != "" || orderChangeTextBox.Text != "")
            {
                if (paymentTypeComboBox.SelectedItem.ToString() == "Card")
                {
                    panel1.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                }
                DataRowView dataRow = paymentTypeComboBox.SelectedItem as DataRowView;
                int paymentID = int.Parse(dataRow.Row["id"].ToString());
                SqlCommand command = new SqlCommand("[sp_close_order]", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId);
                command.Parameters.AddWithValue("@p_pmethod_id", paymentID);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                Forms.OrdersForm orders = new Forms.OrdersForm();
                this.Hide();
                orders.Show();
            }
            else
            {
                MessageBox.Show("You can not close this order. Enter amount.", "Close Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderTotalTextBox.Text != "" && orderReceivedTextBox.Text != "")
                {
                    int rec = int.Parse(orderReceivedTextBox.Text);
                    int tot = int.Parse(orderTotalTextBox.Text);
                    int change = rec - tot;
                    orderChangeTextBox.Text = change.ToString();
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
    }
}
