using System;
using System.Collections;
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
    public partial class AddDishForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        SqlDataAdapter adapter;
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            this.dishTableAdapter.Fill(this.posDBDataSet.Dish);
            showCategoryListView();
        }

        private void showCategoryListView()
        {
            dishCatListView.Items.Clear();
            string query = "select * from Category";
            adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                dishCatListView.Items.Add(item);
            }
        }

        private void clearData()
        {
            dishNameTextBox.Text = "";
            dishFullNameTextBox.Text = "";
            dishCatSelectListView.Items.Clear();
            dishPriceTextBox.Text = "";
            dishDescTextBox.Text = "";
        }

        private void displayData()
        {
            string query = "select * from Dish";
            conn.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            dishGridView.DataSource = table;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearData();
            showCategoryListView();
            string dishID = dishGridView.CurrentRow.Cells[0].Value.ToString();
            string query = "select Dish.id [id], Dish.name [name], Dish.full_name [full_name], Dish.price [price], Dish.description [description], " +
                            "Category.id [category_id], Category.name [category], Category.description [category_description] " +
                            "from Dish left join Dish_Category on Dish.id = Dish_Category.dish_id " +
                            "left join Category on Dish_Category.category_id = Category.id where Dish.id = " + dishID;
            adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                dishIDTextBox.Text = row["id"].ToString();
                dishNameTextBox.Text = row["name"].ToString();
                dishFullNameTextBox.Text = row["full_name"].ToString();
                dishPriceTextBox.Text = row["price"].ToString();
                dishDescTextBox.Text = row["description"].ToString();

                ListViewItem itemSelect = new ListViewItem(row["category_id"].ToString());
                itemSelect.SubItems.Add(row["category"].ToString());
                dishCatSelectListView.Items.Add(itemSelect);
            }
            foreach (ListViewItem categoryItem in dishCatListView.Items)
            {
                foreach (ListViewItem selectCategoryItem in dishCatSelectListView.Items)
                {
                    if (selectCategoryItem.Text == categoryItem.Text)
                    {
                        dishCatListView.Items.Remove(categoryItem);
                    }
                }
            }
        }

        private void AddDishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        
        private void dishNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dishCatListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You have not selected any category.");
            }
            else
            {
                if(MessageBox.Show("Do you want to add categories for this dish?", "Add Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList indexes = new ArrayList(dishCatListView.SelectedItems);
                    foreach(ListViewItem item in indexes)
                    {
                        dishCatListView.Items.Remove(item);
                        dishCatSelectListView.Items.Add(item);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dishCatSelectListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You did not select any categories.");
            }
            else
            {
                if (MessageBox.Show("Do you want to remove categories for this dish?", "Add Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList indexes = new ArrayList(dishCatSelectListView.SelectedItems);
                    foreach (ListViewItem item in indexes)
                    {
                        dishCatSelectListView.Items.Remove(item);
                        dishCatListView.Items.Add(item);
                    }
                }
            }
        }

        private bool checkIfExistForAdd(string name)
        {
            DataTable table = new DataTable();
            string query = "select * from Dish where name = @name";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else 
                return false;
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            if (dishNameTextBox != null && dishCatSelectListView.Items.Count != 0 && dishPriceTextBox != null)
            {
                if ((MessageBox.Show("Are you sure you want to add dish " + dishNameTextBox.Text + "?", "Add Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {
                    if (!checkIfExistForAdd(dishNameTextBox.Text))
                    {
                        string queryInsertDish = "insert into Dish (name, full_name, price, description) values (@name, @full_name, @price, @description)";
                        conn.Open();
                        SqlCommand command = new SqlCommand(queryInsertDish, conn);
                        command.Parameters.AddWithValue("@name", dishNameTextBox.Text);
                        command.Parameters.AddWithValue("@full_name", dishFullNameTextBox.Text);
                        command.Parameters.AddWithValue("@price", dishPriceTextBox.Text);
                        command.Parameters.AddWithValue("@description", dishDescTextBox.Text);
                        command.ExecuteNonQuery();
                        int count = dishCatSelectListView.Items.Count;

                        string query = "select id from Dish where name = @name and full_name = @full_name and price = @price";
                        SqlCommand command3 = new SqlCommand(query, conn);
                        command3.CommandType = CommandType.Text;
                        command3.Parameters.AddWithValue("@name", dishNameTextBox.Text);
                        string dishID = command3.ExecuteScalar().ToString();
                        for (int i = 0; i < count; i++)
                        { 
                            string queryInsertDishCategory = "insert into Dish_Category (dish_id, category_id) values (@dish_id, @category_id)";
                            SqlCommand command2 = new SqlCommand(queryInsertDishCategory, conn);
                            command2.Parameters.AddWithValue("@dish_id", dishID);
                            command2.Parameters.AddWithValue("@category_id", dishCatSelectListView.Items[i].SubItems[0].Text);
                            command2.ExecuteNonQuery();
                        }
                        conn.Close();
                        MessageBox.Show("Dish added.");
                        displayData();
                        clearData();
                        
                    }
                    else
                    {
                        MessageBox.Show("You cannot add an existing dish. Check the data you entered.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not provide data. Please check.");
            }
        }

        private bool checkIfExistForUpdate(string id)
        {
            DataTable table = new DataTable();
            string query = "select * from Dish where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void updateDish()
        {
            conn.Open();
            string query = "update [Dish] set name = @name, full_name = @full_name, price = @price, description = @description where id = @dish_id";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.Parameters.AddWithValue("@name", dishNameTextBox.Text);
            command.Parameters.AddWithValue("@full_name", dishFullNameTextBox.Text);
            command.Parameters.AddWithValue("@price", dishPriceTextBox.Text);
            command.Parameters.AddWithValue("@description", dishDescTextBox.Text);
            command.Parameters.AddWithValue("@dish_id", dishIDTextBox.Text);
            command.ExecuteNonQuery();
            conn.Close();

            query = "select * from Dish_Category where dish_id = @dish_id";
            SqlCommand checkSelectCategoryExist = new SqlCommand(query, conn);
            SqlDataReader reader = checkSelectCategoryExist.ExecuteReader();
            if(!reader.HasRows)
            {
                // not exist
            }
            
            MessageBox.Show("Dish " + dishNameTextBox.Text + " updated.", "Dish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            displayData();
            //    clearData();
        }

        private void updateDish_Category()
        {
            for(int i = 0; i <= dishCatSelectListView.Items.Count; i++)
            {
                string query = "";
            }
        }

        private void updateDishButton_Click(object sender, EventArgs e)
        {
            {
                if ((MessageBox.Show("Are you sure you want to update dish " + dishNameTextBox.Text + "?", "Update Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {
                    //if (checkIfExistForAdd(dishNameTextBox.Text))
                    //{
                    //    MessageBox.Show("You have not made any changes.");
                    //    return;
                    //}
                    if (dishIDTextBox.Text == "0")
                    {
                        MessageBox.Show("You did not select data. Please check.");
                        return;
                    }
                    if (checkIfExistForUpdate(dishIDTextBox.Text))
                        updateDish();
                    else
                    {
                        MessageBox.Show("You cannot update a non-existent category. Check the data you entered.");
                        return;
                    }
                    displayData();
                    clearData();
                }
                else
                {
                    MessageBox.Show("You did not enter data. Please check.");
                }
            }
        }

        private void removeDishButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to remove dish?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (dishIDTextBox.Text != "0")
                {
                    string query = "delete from Dish_Category where dish_id = @id; delete from Dish where id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", dishIDTextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dish " + dishNameTextBox.Text + " deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();
                    clearData();
                }
                else
                {
                    MessageBox.Show("You did not select record to delete.");
                }
            }
        }
    }
}
