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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        int s_category_id = 0;

        public EditOrderForm()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            loadCategoryButtons();
            loadOrder();
        }

        private void loadOrder()
        {
            orderIDTextBox.Text = OrderClass.orderId.ToString();

            dataOrderGridView.Rows.Clear();
            dataOrderGridView.Refresh();
            string query = "select * from [Dish] d join [Order_Dish] on [Order_Dish].dish_id = d.id where [Order_Dish].order_id = " + OrderClass.orderId;
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[]
                    { row["id"].ToString(), row["name"].ToString(), row["quantity"].ToString(), row["price"].ToString() };
                dataOrderGridView.Rows.Add(dataGridViewRow);
            }

            conn.Close();

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
            string query = "select * from [Category]";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Button categoryButton = new Button();
                categoryButton.Size = new Size(65, 35);
                categoryButton.Font = new Font("Malgun Gothic", 8, FontStyle.Regular);
                categoryButton.FlatStyle = FlatStyle.Flat;
                if (counter == 3)
                {
                    // next line
                    buttonPoint = new Point(buttonPoint.X - 210, buttonPoint.Y + 45);
                    counter = 0;
                }
                categoryButton.Location = new Point(buttonPoint.X + 70, buttonPoint.Y);
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataOrderGridView.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow selectedRow in dataOrderGridView.SelectedRows)
                    {
                        dataOrderGridView.Rows.RemoveAt(selectedRow.Index);
                        string query = "DELETE FROM [Order_Dish] WHERE order_id = " + orderIDTextBox.Text + " AND dish_id = " + selectedRow.Cells[0].Value.ToString();
                        SqlCommand command = new SqlCommand(query, conn);
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
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
            try
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
                /*
    sp_update_order
	@p_order_id smallint,
	@p_dish_id smallint,
	@p_quantity int
                */
                
                SqlCommand command1 = new SqlCommand("sp_update_order", conn);
                command1.CommandType = CommandType.StoredProcedure;
                // add value in db
                foreach (DataRow row in table.Rows)
                {
                    conn.Open();
                    command1.Parameters.AddWithValue("@p_order_id", orderID);
                    command1.Parameters.AddWithValue("@p_dish_id", row["id"]);
                    command1.Parameters.AddWithValue("@p_quantity", row["quantity"]);
                    command1.ExecuteScalar();
                    conn.Close();
                    command1.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Forms.OrdersForm orders = new OrdersForm();
            this.Close();
            orders.Show();
        }

        private void orderSaveButton_Click(object sender, EventArgs e)
        {
            if (dataOrderGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Save order?", "Edit Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {

                        dishEditOrder(OrderClass.orderId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Order edited.", "Edit Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Forms.PaymentForm payment = new Forms.PaymentForm();
                        //payment.Show();
                        ////this.Hide();
                        //Forms.OrdersForm orders = new Forms.OrdersForm();
                        //orders.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot create an empty order.", "New Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
