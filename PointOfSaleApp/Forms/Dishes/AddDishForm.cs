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
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();

        public AddDishForm()
        {
            InitializeComponent();
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadDishes();
                if (Classes.DishClass.dishId != 0)
                {
                    string dishID = Classes.DishClass.dishId.ToString();
                    int nRowIndex = 0;
                    foreach (DataGridViewRow row in dishGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(dishID))
                        {
                            nRowIndex = row.Index;
                            break;
                        }
                    }
                    dishGridView.Rows[nRowIndex].Selected = true;
                    dishGridView.FirstDisplayedScrollingRowIndex = nRowIndex;
                    showCategoryListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCategoryListView()
        {
            dishCatListView.Items.Clear();
            string query = "SELECT * FROM Category ORDER BY 1";
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

        private void clearData()
        {
            dishIDTextBox.Text = "0";
            dishNameTextBox.Text = "";
            dishFullNameTextBox.Text = "";
            dishCatSelectListView.Items.Clear();
            showCategoryListView();
            priceNumericUpDown.Value = 0;
            dishDescTextBox.Text = "";
            Classes.DishClass.clearDish();
        }

        private void loadDishes()
        {
            try
            {
                dishGridView.Rows.Clear();
                dishGridView.Refresh();
                string query = "SELECT * FROM VAllDishes";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dishGridView.ColumnCount = 3;
                dishGridView.Columns[0].Name = "ID";
                dishGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dishGridView.Columns[1].Name = "Name";
                dishGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dishGridView.Columns[2].Name = "Price";
                dishGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                           { row["ID"].ToString(), row["Name"].ToString(), row["Price"].ToString() };
                    dishGridView.Rows.Add(dataGridViewRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearData();
                showCategoryListView();
                if (dishGridView.CurrentRow.Cells[0].Value != null)
                    loadSelectDish();
                else
                {
                    Classes.DishClass.clearDish();
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSelectDish()
        {
            string dishID = dishGridView.CurrentRow.Cells[0].Value.ToString();
            string query = "[sp_show_dish_info]";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_dish_id", dishID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                Classes.DishClass.dishId = int.Parse(row["id"].ToString());
                dishNameTextBox.Text = Classes.DishClass.dishName = row["name"].ToString();
                dishFullNameTextBox.Text = Classes.DishClass.dishFullName = row["full_name"].ToString();
                Classes.DishClass.dishPrice = double.Parse(row["price"].ToString());
                dishDescTextBox.Text = Classes.DishClass.dishDescription = row["description"].ToString();

                dishIDTextBox.Text = Classes.DishClass.dishId.ToString();
                priceNumericUpDown.Value = decimal.Parse(Classes.DishClass.dishPrice.ToString());

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

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (dishCatListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You have not selected any category.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to add this categories for this dish?", "Add Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList indexes = new ArrayList(dishCatListView.SelectedItems);
                    foreach (ListViewItem item in indexes)
                    {
                        dishCatListView.Items.Remove(item);
                        dishCatSelectListView.Items.Add(item);
                    }
                }
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (dishCatSelectListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("You did not select any categories.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to remove this category for this dish?", "Add Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            string query = "SELECT * FROM Dish WHERE name = @name";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
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

        private void addDishButton_Click(object sender, EventArgs e)
        {
            if (dishCatSelectListView.Items.Count == 0)
            {
                MessageBox.Show("You did not select any categories.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (priceNumericUpDown.Value <= 0)
            {
                MessageBox.Show("You did not enter price.", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dishName;
            if (dishNameTextBox.Text == null || dishNameTextBox.Text == "0")
                dishName = null;
            else
                dishName = dishNameTextBox.Text;
            string dishFullName;
            if (dishFullNameTextBox.Text == null || dishFullNameTextBox.Text == "")
                dishFullName = null;
            else
                dishFullName = dishFullNameTextBox.Text;
            decimal dishPrice;
            if (priceNumericUpDown.Value.ToString() == "" || priceNumericUpDown.Value.ToString() == "0")
                dishPrice = 0;
            else
                dishPrice = decimal.Parse(priceNumericUpDown.Value.ToString());
            string dishDescription;
            if (dishDescTextBox.Text == null || dishDescTextBox.Text == "")
                dishDescription = null;
            else
                dishDescription = dishDescTextBox.Text;

            if (dishNameTextBox != null && dishCatSelectListView.Items.Count != 0 && priceNumericUpDown != null ||
                dishNameTextBox.Text != "" && dishCatSelectListView.Items.Count != 0 && priceNumericUpDown.Value != 0)
            {
                if (MessageBox.Show("Are you sure you want to add dish " + dishName + "?", "Add Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (!checkIfExistForAdd(dishNameTextBox.Text))
                    {
                        try
                        {
                            int dishId = createDish(dishName, dishFullName, dishPrice, dishDescription);

                            int count = dishCatSelectListView.Items.Count;
                            List<int> dishCategoryListIds = new List<int>();
                            for (int i = 0; i < count; i++)
                                dishCategoryListIds.Add(int.Parse(dishCatSelectListView.Items[i].SubItems[0].Text));
                            List<int> dishCategoryDBIds = getCategoryIdFromDB(dishId);

                            List<int> insertIds = dishCategoryListIds.Except(dishCategoryDBIds).ToList();
                            List<int> deleteIds = dishCategoryDBIds.Except(dishCategoryListIds).ToList();


                            int resultInsert = 1;
                            if (insertIds.Count > 0)
                                insertCategories(dishId, insertIds);
                            int resultDelete = 1;
                            if (deleteIds.Count > 0)
                                deleteCategories(dishId, deleteIds);

                            if (resultDelete > 0 && resultInsert > 0)
                                MessageBox.Show("Dish " + dishNameTextBox.Text + " added.");
                            else
                                MessageBox.Show("Dish " + dishNameTextBox.Text + " has not been added.");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        loadDishes();
                        clearData();

                        dishGridView.ClearSelection();
                        int nRowIndex = dishGridView.Rows.Count - 2;
                        dishGridView.Rows[nRowIndex].Cells[0].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("You cannot add an existing dish. Check the data you entered.", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("You did not provide data. Please check.", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int insertCategories(int dishId, List<int> insertIds)
        {
            int sum = 0;
            foreach (int categoryId in insertIds)
            {
                string query = "[sp_insert_update_dish_category]";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dish_id", dishId);
                command.Parameters.AddWithValue("@category_id", categoryId);
                int result = command.ExecuteNonQuery();
                sum += result;
                conn.Close();
                command.Parameters.Clear();
            }
            return sum;
        }

        private int deleteCategories(int dishId, List<int> deleteIds)
        {
            int sum = 0;
            foreach (int categoryId in deleteIds)
            {
                string query = "DELETE FROM [Dish_Category] WHERE dish_id = @dish_id AND category_id = @category_id";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@dish_id", dishId);
                command.Parameters.AddWithValue("@category_id", categoryId);
                int result = command.ExecuteNonQuery();
                sum += result;
                conn.Close();
                command.Parameters.Clear();
            }
            return sum;
        }

        private List<int> getCategoryIdFromDB(int dish_id)
        {
            List<int> retval = new List<int>();
            string query = "SELECT category_id FROM [Dish_Category] WHERE dish_id = @dish_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@dish_id", dish_id);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                retval.Add(int.Parse(row[0].ToString()));
            return retval;
        }

        private int createDish(string dishName, string dishFullName, decimal dishPrice, string dishDescription)
        {
            int retval = 0;
            try
            {
                string query = "[sp_insert_dish]";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_name", dishName);
                command.Parameters.AddWithValue("@p_full_name", dishFullName);
                command.Parameters.AddWithValue("@p_price", dishPrice);
                command.Parameters.AddWithValue("@p_description", dishDescription);

                command.Parameters.Add("@dish_id", System.Data.SqlDbType.SmallInt).Direction = System.Data.ParameterDirection.ReturnValue;

                conn.Open();
                command.ExecuteNonQuery();
                retval = (int)command.Parameters["@dish_id"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return retval;
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
            if (dishCatSelectListView.Items.Count <= 0)
            {
                MessageBox.Show("You did not select any categories.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dishId;
            if (dishIDTextBox.Text == null || dishIDTextBox.Text == "" || dishIDTextBox.Text == "0")
                dishId = 0;
            else
                dishId = int.Parse(dishIDTextBox.Text);
            string dishName;
            if (dishNameTextBox.Text == null || dishNameTextBox.Text == "")
                dishName = null;
            else
                dishName = dishNameTextBox.Text;
            string dishFullName;
            if (dishFullNameTextBox.Text == null || dishFullNameTextBox.Text == "")
                dishFullName = null;
            else
                dishFullName = dishFullNameTextBox.Text;
            decimal dishPrice;
            if (priceNumericUpDown.Value.ToString() == "" || priceNumericUpDown.Value == 0)
                dishPrice = 0;
            else
                dishPrice = decimal.Parse(priceNumericUpDown.Value.ToString());
            string dishDescription;
            if (dishDescTextBox.Text == null || dishDescTextBox.Text == "")
                dishDescription = null;
            else 
                dishDescription = dishDescTextBox.Text;

            int isSuccess = -1;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("[sp_update_dish]", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_dish_id", dishId);
                command.Parameters.AddWithValue("@p_name", dishName);
                command.Parameters.AddWithValue("@p_full_name", dishFullName);
                command.Parameters.AddWithValue("@p_price", dishPrice);
                if (dishDescription == null)
                    command.Parameters.AddWithValue("@p_description", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    command.Parameters.AddWithValue("@p_description", dishDescription);
                isSuccess = command.ExecuteNonQuery();
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
                conn.Close();
            }

            int count = dishCatSelectListView.Items.Count;
            List<int> dishCategoryListIds = new List<int>();
            for (int i = 0; i < count; i++)
                dishCategoryListIds.Add(int.Parse(dishCatSelectListView.Items[i].SubItems[0].Text));
            List<int> dishCategoryDBIds = getCategoryIdFromDB(dishId);

            List<int> insertIds = dishCategoryListIds.Except(dishCategoryDBIds).ToList();
            List<int> deleteIds = dishCategoryDBIds.Except(dishCategoryListIds).ToList();

            int resultInsert = 1;
            if (insertIds.Count > 0)
                insertCategories(dishId, insertIds);
            int resultDelete = 1;
            if (deleteIds.Count > 0)
                deleteCategories(dishId, deleteIds);

            if (isSuccess > 0 && resultDelete > 0 && resultInsert > 0)
                MessageBox.Show("Dish " + dishName + " updated.", "Dish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Dish " + dishName + " has not updated.", "Dish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateDishButton_Click(object sender, EventArgs e)
        {
            if (dishCatSelectListView.Items.Count == 0)
            {
                MessageBox.Show("You did not select any categories.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (priceNumericUpDown.Value <= 0)
            {
                MessageBox.Show("You did not enter price.", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((MessageBox.Show("Are you sure you want to update dish " + dishNameTextBox.Text + "?", "Update Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (dishIDTextBox.Text == "0" && dishNameTextBox.Text == "")
                {
                    MessageBox.Show("You did not select data. Please check.", "Category Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkIfExistForUpdate(dishIDTextBox.Text))
                    updateDish();
                else
                {
                    MessageBox.Show("You cannot update a non-existent category. Check the data you entered.", "Category Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                loadDishes();
            }
        }

        private void removeDish()
        {
            try
            {
                int dishId = int.Parse(dishIDTextBox.Text);
                conn.Open();
                string query = "[sp_delete_dish]";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_dish_id", dishId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void removeDishButton_Click(object sender, EventArgs e)
        {
            if (dishCatSelectListView.Items.Count == 0)
            {
                MessageBox.Show("You did not select any categories.", "Select Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (priceNumericUpDown.Value <= 0)
            {
                MessageBox.Show("You did not enter price.", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if ((MessageBox.Show("Are you sure you want to remove dish?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {
                    if (dishIDTextBox.Text != "0")
                    {
                        removeDish();
                        MessageBox.Show("Dish " + dishNameTextBox.Text + " deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDishes();
                        clearData();
                    }
                    else
                    {
                        MessageBox.Show("You did not select record to delete.", "Category Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dishGridView.ClearSelection();
                    dishGridView.Rows[0].Cells[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

        private void priceNumericUpDown_Leave(object sender, EventArgs e)
        {
            string priceText = priceNumericUpDown.Value.ToString();
            for (int i=0; i<priceText.Length; i++)
            {
                decimal num = 0;
                bool canConvert = decimal.TryParse(priceText, out num);
                if (!canConvert && num > 0)
                {
                    MessageBox.Show("Please enter a valid number.");
                    priceNumericUpDown.Value = 0;
                    return;
                }
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
            Classes.DishClass.clearDish();
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
