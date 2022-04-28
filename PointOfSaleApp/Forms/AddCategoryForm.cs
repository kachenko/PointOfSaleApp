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
        SqlDataAdapter adapter;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = UserClass.userLogin.ToString();
            positLabel.Text = UserClass.userRole.ToString();
            FillListProdView();
        }

        public void FillListProdView()
        {
            listCatView.Items.Clear();
            listCatView.View = View.Details;
            string query = "select * from [DishCategory]";
            adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["description"].ToString());
                listCatView.Items.Add(item);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInsert = "insert into [DishCategory] (name, description) values(@name, @description)";
            SqlCommand command = new SqlCommand(queryInsert, conn);
            command.Parameters.AddWithValue("@name", prodCatTextBox.Text);
            command.Parameters.AddWithValue("@description", prodCatDesTextBox.Text);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            MessageBox.Show("Category " + prodCatTextBox.Text + " added.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prodCatTextBox.Text = "";
            prodCatDesTextBox.Text = "";
            conn.Close();
            listCatView.Items.Clear();
            FillListProdView();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
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
    }
}
