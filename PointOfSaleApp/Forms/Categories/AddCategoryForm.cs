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
    public partial class AddCategoryForm2 : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        SqlCommand cmd;

        public AddCategoryForm2()
        {
            InitializeComponent();
        }

        private void AddCategoryForm2_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void clearData()
        {
            prodCatIDTextBox.Text = "0";
            prodCatTextBox.Text = "";
            prodCatDesTextBox.Text = "";
        }

        private void loadCategories()
        {
            categoryGridView.Rows.Clear();
            categoryGridView.Refresh();
            string query = "SELECT * FROM VAllCategories";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                categoryGridView.ColumnCount = 3;
                categoryGridView.Columns[0].Name = "ID";
                categoryGridView.Columns[1].Name = "Name";
                categoryGridView.Columns[2].Name = "Description";

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["ID"].ToString(), row["Name"].ToString(), row["Description"].ToString() };
                    categoryGridView.Rows.Add(dataGridViewRow);
                }


                string categoryID = Classes.CategoryClass.categoryId.ToString();
                int nRowIndex = 0;
                if (categoryID != "0")
                {
                    foreach (DataGridViewRow row in categoryGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(categoryID))
                        {
                            nRowIndex = row.Index;
                            break;
                        }
                    }
                    categoryGridView.Rows[nRowIndex].Selected = true;
                }
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
        }

        private void CategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (categoryGridView.CurrentRow.Cells[0].Value != null)
                {
                    Classes.CategoryClass.categoryId = int.Parse(categoryGridView.CurrentRow.Cells[0].Value.ToString());
                    Classes.CategoryClass.categoryName = categoryGridView.CurrentRow.Cells[1].Value.ToString();
                    Classes.CategoryClass.categoryDescription = categoryGridView.CurrentRow.Cells[2].Value.ToString();

                    prodCatIDTextBox.Text = Classes.CategoryClass.categoryId.ToString();
                    prodCatTextBox.Text = Classes.CategoryClass.categoryName;
                    prodCatDesTextBox.Text = Classes.CategoryClass.categoryDescription;
                }
                else
                {
                    Classes.CategoryClass.сlearCategory();
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkIfExistForAdd(int id, string name, string description)
        {
            string query = "SELECT * FROM Category WHERE id = @id OR name = @name OR description = @description";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            if (description == null)
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@description", description);
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

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodCatTextBox.Text != null && prodCatTextBox.Text != "")
                {
                    int categoryID;
                    if (prodCatIDTextBox.Text == "" || prodCatIDTextBox.Text == null)
                        categoryID = 0;
                    else
                        categoryID = int.Parse(prodCatIDTextBox.Text);
                    string categoryName;
                    if (prodCatTextBox.Text == "" || prodCatTextBox.Text == null)
                        categoryName = null;
                    else
                        categoryName = prodCatTextBox.Text;
                    string categoryDescription;
                    if (prodCatDesTextBox.Text == "" || prodCatDesTextBox.Text == null)
                        categoryDescription = null;
                    else
                        categoryDescription = prodCatDesTextBox.Text;
                    if (MessageBox.Show("Are you sure you want to add category " + categoryName + "?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (!checkIfExistForAdd(categoryID, categoryName, categoryDescription))
                        {
                            int isSuccess = -1;
                            try
                            {
                                string query = "[sp_insert_category]";
                                cmd = new SqlCommand(query, conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@p_category_name", categoryName);
                                if (categoryDescription == null)
                                    cmd.Parameters.AddWithValue("@p_category_description", SqlDbType.NVarChar).Value = DBNull.Value;
                                else
                                    cmd.Parameters.AddWithValue("@p_category_description", categoryDescription);

                                conn.Open();
                                isSuccess = cmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("SQL EXCEPTION: " + ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                            if (isSuccess > 0)
                                MessageBox.Show("Category " + categoryName + " added.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Category " + categoryName + " not added.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loadCategories();
                            clearData();
                        }
                        else
                        {
                            MessageBox.Show("You cannot add an existing category. Check the data you entered.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You did not provide data. Please check.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Helper
        private bool checkIfExistForUpdate(int id)
        {
            string query = "SELECT * FROM Category WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
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

        private void updateCategory(int categoryID, string categoryName, string categoryDescription)
        {
            int isSuccess = -1;
            string queryUpdate = "[sp_update_category]";
            try
            {
                SqlCommand command = new SqlCommand(queryUpdate, conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                command.Parameters.AddWithValue("@p_id", categoryID);
                command.Parameters.AddWithValue("@p_name", categoryName);

                if (categoryDescription == null)
                    command.Parameters.AddWithValue("@p_description", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    command.Parameters.AddWithValue("@p_description", categoryDescription);
                // command.Parameters.AddWithValue("@p_description", categoryDescription);
                isSuccess = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (isSuccess > 0)
                MessageBox.Show("Category " + categoryName + " updated.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Category " + categoryName + "has not been updated.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadCategories();
            clearData();
        }

        private bool checkIfNoChange(int id, string name, string description)
        {
            string query = "SELECT * FROM Category WHERE id = @id AND name = @name AND description = @description";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name); 
            if (description == null)
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@description", description);
            // command.Parameters.AddWithValue("@description", description);
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

    private void updateCategoryButton_Click(object sender, EventArgs e)
    {
        int categoryID = int.Parse(prodCatIDTextBox.Text);
        string categoryName;
        if (prodCatTextBox.Text == "" || prodCatTextBox.Text == null)
            categoryName = null;
        else
            categoryName = prodCatTextBox.Text;
        string categoryDescription;
        if (prodCatDesTextBox.Text == "" || prodCatDesTextBox.Text == null)
            categoryDescription = null;
        else
            categoryDescription = prodCatDesTextBox.Text;

            try
            {
                if (prodCatTextBox == null || prodCatTextBox.Text == "")
                {
                    MessageBox.Show("You did not provide data.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((MessageBox.Show("Are you sure you want to update a category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {

                    if (checkIfNoChange(categoryID, categoryName, categoryDescription))
                    {
                        MessageBox.Show("You have not made any changes.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (checkIfExistForUpdate(categoryID))
                    {
                        updateCategory(categoryID, categoryName, categoryDescription);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("You cannot update a non-existent category.", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodCatIDTextBox.Text != "0" || prodCatTextBox.Text != "" && prodCatDesTextBox.Text != "")
                {
                    if ((MessageBox.Show("Are you sure you want to remove category? \nLinks to this category will be deleted.", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                    {
                        int isSuccess = -1;
                        string query = "[sp_delete_category]";
                        try
                        {
                            cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_category_id", prodCatIDTextBox.Text);
                            conn.Open();
                            isSuccess = cmd.ExecuteNonQuery();
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
                        if (isSuccess > 0)
                            MessageBox.Show("Category " + prodCatTextBox.Text + " deleted.", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Category " + prodCatTextBox.Text + " not deleted.", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Classes.CategoryClass.сlearCategory();
                        loadCategories();
                        clearData();
                    }
                }
                else
                {
                    MessageBox.Show("You did not select record to delete.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCategoryForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            clearData();
            categoryGridView.Rows[0].Selected = true;
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

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
