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
        // private static DataTable dataTabDish = new DataTable();

        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public NewOrderForm()
		{
			InitializeComponent();
		}
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            userPictureBox.Image = MyUserClass.loadUserPicture();
            Forms.OrderTableForm table = new Forms.OrderTableForm();
            table.ShowDialog();
            tableTextBox.Text = OrderClass.orderTableNr.ToString();
            loadCategoryButtons();
            setNewOrderNumber();
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void clearData()
        {
            dishIDTextBox.Text = "";
            dishNameTextBox.Text = "";
            dishFullNameTextBox.Text = "";
            dishPriceTextBox.Text = "";
            dishDescTextBox.Text = "";
            dishQuantityUpDown.Value = 1;
        }

        private void setNewOrderNumber()
        {
            string query = "select top 1 id from [Order] order by id desc";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                object lastOrder = command.ExecuteScalar();
                if (lastOrder != null)
                {
                    string lastOrderString = Convert.ToString(lastOrder);
                    orderIDTextBox.Text = lastOrderString;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                int dish_id = int.Parse(dishIDTextBox.Text);
                OrderClass.AddDishID(dish_id);
                dataOrderGridView.ColumnCount = 4;
                dataOrderGridView.Columns[0].Name = "ID";
                dataOrderGridView.Columns[1].Name = "Name";
                dataOrderGridView.Columns[2].Name = "Quantity";
                dataOrderGridView.Columns[3].Name = "Price";

                string[] dataGridViewRow = new string[] 
                    { dishIDTextBox.Text, dishNameTextBox.Text, dishQuantityUpDown.Value.ToString(), dishPriceTextBox.Text };
                dataOrderGridView.Rows.Add(dataGridViewRow);

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

        private void removeButton_Click(object sender, EventArgs e)
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



        /*
         if (MessageBox.Show("Create an Order?", "Create Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    OrderClass.orderId = int.Parse(dishIDTextBox.Text);
                    OrderClass.orderTableNr = int.Parse(tableTextBox.Text);
                    OrderClass.orderTime = DateTime.Now;
                    OrderClass.orderPrice = int.Parse(dishPriceTextBox.Text);
                    OrderClass.orderIsActive = true;
                    string query = "[sp_create_order] " + OrderClass.orderTableNr + ", " + OrderClass.orderTime + ", " + OrderClass.orderPrice + ", " + MyUserClass.userId + ", " + OrderClass.orderIsActive;
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
         * */
    }
}
