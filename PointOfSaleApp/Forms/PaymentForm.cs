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
            loadItems(OrderClass.orderId);
        }

        private void loadItems(int orderID)
        {
            try
            {
                dataPriceGridView.Rows.Clear();
                dataPriceGridView.Refresh();
                string query = "select *, od.quantity * d.price [price_dish], o.price [order_price] from [Dish] d join [Order_Dish] od on d.id = od.dish_id join [Order] o on o.id = od.order_id where od.order_id = " + orderID;
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["dish_id"].ToString(), row["name"].ToString(), row["quantity"].ToString(), row["price_dish"].ToString() };
                    dataPriceGridView.Rows.Add(dataGridViewRow);
                }
                conn.Close();

                string query2 = "select * from [Order] where id = " + OrderClass.orderId;
                conn.Open();
                SqlCommand command2 = new SqlCommand(query2, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                foreach (DataRow row2 in table2.Rows)
                {
                    orderTotalTextBox.Text = row2["price"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeOrderButton_Click(object sender, EventArgs e)
        {
            if (orderTotalTextBox.Text != "" || orderReceivedTextBox.Text != "" || orderChangeTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("[sp_close_order]", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId); 
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
            Forms.EditOrderForm editOrder = new Forms.EditOrderForm();
            this.Hide();
            editOrder.Show();
        }
    }
}
