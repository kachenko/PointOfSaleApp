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
    public partial class DishesMenuForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public DishesMenuForm()
        {
            InitializeComponent();
        }

        private void DishesMenuForm_Load(object sender, EventArgs e)
        {
            loadCategoryButtons();
            if (MyUserClass.userRoleId == 1 || MyUserClass.userRoleId == 2)
            {
                modifyDishButton.Visible = true;
            }
            else
            {
                modifyDishButton.Visible = true;
            }
        }

        private void loadCategoryButtons()
        {
            try
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
                    categoryButton.Size = new Size(70, 40);
                    categoryButton.Font = new Font("Malgun Gothic", 8, FontStyle.Regular);
                    categoryButton.FlatStyle = FlatStyle.Flat;
                    if (counter == 3)
                    {
                        // next line
                        buttonPoint = new Point(buttonPoint.X - 225, buttonPoint.Y + 45);
                        counter = 0;
                    }
                    categoryButton.Location = new Point(buttonPoint.X + 75, buttonPoint.Y);
                    categoryButton.Name = "category" + row["name"] + "Button";
                    categoryButton.Text = row["name"].ToString();
                    categoryButtonPanel.Controls.Add(categoryButton);
                    buttonPoint = categoryButton.Location;
                    counter++;

                    categoryButton.Click += new EventHandler(this.categoryButtonClick);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = buttonClick.Text;
                Classes.CategoryClass.categoryId = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Classes.CategoryClass.categoryName = buttonClick.Text;
            categoryLabel.Text = buttonClick.Text;
            loadDishDataGridView();
        }

        private void loadDishDataGridView()
        {
            dishMenuDataGridView.Rows.Clear();
            dishMenuDataGridView.Refresh();
            string query = "[sp_show_dish_by_category]";
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_category_id", Classes.CategoryClass.categoryId);
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
                conn.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dishMenuDataGridView.ColumnCount = 4;
            dishMenuDataGridView.Columns[0].Name = "ID";
            dishMenuDataGridView.Columns[1].Name = "Name";
            dishMenuDataGridView.Columns[2].Name = "Full Name";
            dishMenuDataGridView.Columns[3].Name = "Price";

            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[]
                    { row["id"].ToString(), row["name"].ToString(), row["full_name"].ToString(), row["price"].ToString() };
                dishMenuDataGridView.Rows.Add(dataGridViewRow);
            }

            conn.Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Classes.DishClass.clearDish();
            Classes.DishClass.dishId = int.Parse(dishMenuDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            Forms.AddDishForm dishForm = new AddDishForm();
            dishForm.Show();
        }

        private void DishesMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void dishMenuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
