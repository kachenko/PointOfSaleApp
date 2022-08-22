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
    public partial class PaymentMethodForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public PaymentMethodForm()
        {
            InitializeComponent();
        }

        private void PaymentMethodForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaymentMethods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadPaymentMethods()
        {
            paymentMethodGridView.Rows.Clear();
            paymentMethodGridView.Refresh();
            string query = "SELECT * FROM [PaymentMethod]";
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            paymentMethodGridView.ColumnCount = 2;
            paymentMethodGridView.Columns[0].Name = "ID";
            paymentMethodGridView.Columns[1].Name = "Name";

            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[]
                    { row["id"].ToString(), row["name"].ToString() };
                paymentMethodGridView.Rows.Add(dataGridViewRow);
            }
            conn.Close();
        }

        private void paymentMethodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (paymentMethodGridView.CurrentRow.Cells[0].Value != null)
                {
                    paymentIDTextBox.Text = paymentMethodGridView.CurrentRow.Cells[0].Value.ToString();
                    paymentNameTextBox.Text = paymentMethodGridView.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData()
        {
            paymentIDTextBox.Text = "0";
            paymentNameTextBox.Text = "";
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPaymentMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymentIDTextBox.Text != "0" || paymentNameTextBox.Text != "")
                {
                    int paymentID;
                    if (paymentIDTextBox.Text == "" || paymentIDTextBox.Text == null)
                        paymentID = 0;
                    else
                        paymentID = int.Parse(paymentIDTextBox.Text);
                    string paymentName;
                    if (paymentNameTextBox.Text == "" || paymentNameTextBox.Text == null)
                        paymentName = null;
                    else
                        paymentName = paymentNameTextBox.Text;
                    if (MessageBox.Show("Are you sure you want to add payment method: " + paymentName + "?", "Add Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (!checkIfExistForAdd(paymentID, paymentName))
                        {
                            string query = "[sp_insert_payment]";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_name", paymentName);
                            
                            conn.Open();
                            int isSuccess = cmd.ExecuteNonQuery();
                            conn.Close();

                            if (isSuccess > 0)
                                MessageBox.Show("Payment Method " + paymentName + " added.", "Payment Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Payment Method not added.", "Payment Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loadPaymentMethods();
                            clearData();
                        }
                        else
                        {
                            MessageBox.Show("You cannot add an existing method. Check the data you entered.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You did not provide data. Please check.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkIfExistForAdd(int paymentID, string paymentName)
        {
            string query = "SELECT * FROM [PaymentMethod] WHERE id = @id AND name = @name";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", paymentID);
            command.Parameters.AddWithValue("@name", paymentName);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        private void removePaymentMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                string paymentName = paymentNameTextBox.Text;
                if (paymentIDTextBox.Text != "0" && paymentNameTextBox.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to remove this payment method?", "Delete Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string query = "[sp_delete_payment]";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_name", paymentName);

                        conn.Open();
                        int isSuccess = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (isSuccess > 0)
                            MessageBox.Show("Payment Method deleted.", "Payment Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Payment Method not deleted.", "Payment Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadPaymentMethods();
                        clearData();
                    }
                }
                else
                {
                    MessageBox.Show("You did not select any data. Please check.", "Add Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaymentMethodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.Show();
        }
    }
}
