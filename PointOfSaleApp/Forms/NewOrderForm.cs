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

        private void setNewOrderNumber()
        {
            string query = "select top 1 id from[Order] order by datetime desc";
            SqlCommand command = new SqlCommand(query, conn);
            orderIDTextBox.Text = command.ExecuteScalar().ToString(); 
        }

        private void loadCategoryButtons()
        {
            // count buttons
            int counter = 0;
            Point buttonPoint = new Point(0, 0);
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
            string query = "select Dish.* from [Dish] join Dish_Category on Dish.id = Dish_Category.dish_id join Category on Dish_Category.category_id = Category.id where category_id = " + s_category_id;
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            dataDishGridView.DataSource = table;

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
            dishIDTextBox.Text = dataDishGridView.CurrentRow.Cells["id"].Value.ToString();
            dishNameTextBox.Text = dataDishGridView.CurrentRow.Cells["name"].Value.ToString();
            dishFullNameTextBox.Text = dataDishGridView.CurrentRow.Cells["full_name"].Value.ToString();
            dishPriceTextBox.Text = dataDishGridView.CurrentRow.Cells["price"].Value.ToString();
            dishDescTextBox.Text = dataDishGridView.CurrentRow.Cells["description"].Value.ToString();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {

        }
    }
}
