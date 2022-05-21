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
    public partial class AddCategoryForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
            FillListProdView();
        }

        public void FillListProdView()
        {
            listCatView.Items.Clear();
            listCatView.View = View.Details;
            conn.Open();
            string query = "select * from [DishCategory]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["description"].ToString());
                listCatView.Items.Add(item);
            }
            conn.Close();
        }

        private void addCategory()
        {
            if (!checkIfExistForAdd(prodCatTextBox.Text))
            {
                string queryInsert = "insert into [DishCategory] (name, description) values(@name, @description)";
                SqlCommand command = new SqlCommand(queryInsert, conn);
                command.Parameters.AddWithValue("@name", prodCatTextBox.Text);
                command.Parameters.AddWithValue("@description", prodCatDesTextBox.Text);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Category " + prodCatTextBox.Text + " added.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prodCatTextBox.Text = "";
                prodCatDesTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You cannot add an existing category. Check the data you entered.");
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            addCategory();
            listCatView.Items.Clear();
            FillListProdView();
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                string id = listCatView.SelectedItems[0].SubItems[0].Text;
                string queryDelete = "delete from [DishCategory] where id = " + id;
                SqlCommand command = new SqlCommand(queryDelete, conn);
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Category " + prodCatTextBox.Text + " deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                prodCatTextBox.Text = "";
                prodCatDesTextBox.Text = "";
                conn.Close();
                listCatView.Items.Clear();
                FillListProdView();
            }
        }

        private bool checkIfExistForUpdate(string id)
        {
            DataTable table = new DataTable();
            string query = "select * from DishCategory where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if(table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private bool checkIfExistForAdd(string name)
        {
            DataTable table = new DataTable();
            string query = "select * from DishCategory where name = @name";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to update category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string id = listCatView.SelectedItems[0].SubItems[0].Text;
                    string queryUpdate = "update DishCategory set name = @name, description = @description where id = " + id;
                    SqlCommand command = new SqlCommand(queryUpdate, conn);
                    command.Parameters.AddWithValue("@name", prodCatTextBox.Text);
                    command.Parameters.AddWithValue("@description", prodCatDesTextBox.Text);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category " + prodCatTextBox.Text + " updated.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listCatView.Items.Clear();
                    FillListProdView();
                }
                catch(ArgumentOutOfRangeException)
                {
                    if((MessageBox.Show("Category is not exist. Do you want to create category?", "Category is not exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        addCategory();
                        listCatView.Items.Clear();
                        FillListProdView();
                    }
                }
            }
        }

        private void listCatView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listCatView.SelectedItems)
            {
                string name = listCatView.SelectedItems[0].SubItems[1].Text;
                string description = listCatView.SelectedItems[0].SubItems[2].Text;
                prodCatTextBox.Text = name;
                prodCatDesTextBox.Text = description;
            }
        }

        private void AddCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
