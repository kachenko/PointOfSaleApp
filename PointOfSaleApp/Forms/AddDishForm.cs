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
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'posDBDataSet.Dish' . Możesz go przenieść lub usunąć.
            this.dishTableAdapter.Fill(this.posDBDataSet.Dish);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'posDBDataSet.Dish' . Możesz go przenieść lub usunąć.
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            showCategoryListView();
        }

        private void showCategoryListView()
        {
            dishCatListView.Items.Clear();
            try
            {
                string query = "select * from Category order by 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData()
        {
            dishIDTextBox.Text = "0";
            dishNameTextBox.Text = "";
            dishFullNameTextBox.Text = "";
            dishCatSelectListView.Items.Clear();
            dishPriceTextBox.Text = "";
            dishDescTextBox.Text = "";
        }

        private void displayData()
        {
            string query = "select * from Dish";
            try
            {
                conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(table);
                dishGridView.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearData();
            showCategoryListView();
            try
            {
                string dishID = dishGridView.CurrentRow.Cells[0].Value.ToString();
                string query = "select Dish.id [id], Dish.name [name], Dish.full_name [full_name], Dish.price [price], Dish.description [description], " +
                                "Category.id [category_id], Category.name [category], Category.description [category_description] " +
                                "from Dish left join Dish_Category on Dish.id = Dish_Category.dish_id " +
                                "left join Category on Dish_Category.category_id = Category.id where Dish.id = " + dishID;
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            DataTable table2 = new DataTable();
            string query = "select * from Dish where name = '" + name + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter2.Fill(table2);
            int count = table2.Rows.Count;
            if (count > 0)
                return true;
            return false;
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            // CHECK IF PRICE IS VARCHAR
            string priceText = dishPriceTextBox.Text;
            if (dishNameTextBox != null && dishCatSelectListView.Items.Count != 0 && dishPriceTextBox != null ||
                dishNameTextBox.Text != "" && dishPriceTextBox.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to add dish " + dishNameTextBox.Text + "?", "Add Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (!checkIfExistForAdd(dishNameTextBox.Text))
                    {
                        dishIDTextBox.Text = "0";
                        string queryInsertDish = "insert into Dish (name, full_name, price, description) values (@name, @full_name, @price, @description)";
                        try
                        {
                            conn.Open();
                            SqlCommand command = new SqlCommand(queryInsertDish, conn);
                            command.Parameters.AddWithValue("@name", dishNameTextBox.Text);
                            command.Parameters.AddWithValue("@full_name", dishFullNameTextBox.Text);
                            command.Parameters.AddWithValue("@price", dishPriceTextBox.Text);
                            command.Parameters.AddWithValue("@description", dishDescTextBox.Text);
                            command.ExecuteNonQuery();

                            int count = dishCatSelectListView.Items.Count;

                            string query = "select id from Dish where name = @name";
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Dish " + dishNameTextBox.Text + " added.");
                        displayData();
                        // clearData();

                        dishGridView.ClearSelection();
                        int nRowIndex = dishGridView.Rows.Count - 2;
                        dishGridView.Rows[nRowIndex].Cells[0].Selected = true;
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
            try
            {
                DataTable table = new DataTable();
                string query = "select * from Dish where id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void updateDish()
        {
            try
            {
                conn.Open();
                string query = "update [Dish] set name = @name, full_name = @full_name, price = @price, description = @description where id = @dish_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", dishNameTextBox.Text);
                command.Parameters.AddWithValue("@full_name", dishFullNameTextBox.Text);
                command.Parameters.AddWithValue("@price", dishPriceTextBox.Text);
                command.Parameters.AddWithValue("@description", dishDescTextBox.Text);
                command.Parameters.AddWithValue("@dish_id", dishIDTextBox.Text);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            updateDish_Category();

            MessageBox.Show("Dish " + dishNameTextBox.Text + " updated.", "Dish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // displayData();
        }

        private void updateDish_Category()
        {
            try
            {
                conn.Open();
                DataTable table2 = new DataTable();
                string query = "select * from Dish_Category where dish_id = @dish_id";
                SqlCommand command2 = new SqlCommand(query, conn);
                command2.Parameters.AddWithValue("@dish_id", dishIDTextBox.Text);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                adapter2.Fill(table2);
                conn.Close();

                foreach (DataRow row in table2.Rows)
                {
                    string rowDish_CategoryID = row[0].ToString();
                    string rowCategoryID = row[2].ToString();
                    if (dishCatSelectListView.FindItemWithText(rowCategoryID) == null)
                    {
                        conn.Open();
                        MessageBox.Show(rowCategoryID + " is not exist in listView...");
                        // Delete from DB
                        string queryDelete = "delete from [Dish_Category] where id = @id";
                        SqlCommand command1 = new SqlCommand(queryDelete, conn);
                        command1.Parameters.AddWithValue("@id", rowDish_CategoryID);
                        SqlDataReader reader = command1.ExecuteReader();
                        conn.Close();
                    }
                }

                // if in listView is and in DB is not exist - insert into DB
                int count = dishCatSelectListView.Items.Count;
                conn.Open();
                for (int i = 0; i < count; i++)
                {
                    ListViewItem item = dishCatSelectListView.Items[i];
                    string categoryID = item.SubItems[0].Text;
                    string categoryName = item.SubItems[1].Text;
                    string queryCategory = "[sp_update_insert_dish_category] @dish_id, @category_id";
                    SqlCommand command3 = new SqlCommand(queryCategory, conn);
                    command3.Parameters.AddWithValue("@dish_id", dishIDTextBox.Text);
                    command3.Parameters.AddWithValue("@category_id", categoryID);
                    command3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateDishButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to update dish " + dishNameTextBox.Text + "?", "Update Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (dishIDTextBox.Text == "0" && dishNameTextBox.Text == "")
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
            }
        }

        private void removeDish()
        {
            try
            {
                conn.Open();
                string query = "delete from Dish_Category where dish_id = @id; delete from Dish where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", dishIDTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeDishButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to remove dish?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (dishIDTextBox.Text != "0")
                {
                    removeDish();
                    MessageBox.Show("Dish " + dishNameTextBox.Text + " deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();
                    clearData();
                }
                else
                {
                    MessageBox.Show("You did not select record to delete.");
                }
                dishGridView.ClearSelection();
                dishGridView.Rows[0].Cells[0].Selected = true;
            }
        }

        private void clearDishButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear the data?", "Clear Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearData();
                showCategoryListView();
            }
        }

        private void dishPriceTextBox_Leave(object sender, EventArgs e)
        {
            string priceText = dishPriceTextBox.Text;
            for (int i=0; i<priceText.Length; i++)
            {
                if (!char.IsDigit(priceText[i]))
                {
                    MessageBox.Show("Please enter a valid number.");
                    dishPriceTextBox.Text = "";
                    return;
                }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }
    }
}
