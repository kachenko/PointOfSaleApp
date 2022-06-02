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
    public partial class UsersManagementForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public UsersManagementForm()
        {
            InitializeComponent();
            loadUsers();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

        private void loadUsers()
        {
            try
            {
                dataUsersGridView.Rows.Clear();
                dataUsersGridView.Refresh();
                string query = "select * from [User]";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string[] dataGridViewRow = new string[]
                        { row["id"].ToString(), row["login"].ToString(), row["full_name"].ToString(), row["address"].ToString(), row["phone"].ToString(), row["role"].ToString(), row["isActive"].ToString() };
                    dataUsersGridView.Rows.Add(dataGridViewRow);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataUsersGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataUsersGridView.Rows[selectedIndex];
                Classes.SelectedUserClass.userId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                Classes.SelectedUserClass.userLogin = selectedRow.Cells["login"].Value.ToString();

                Forms.ChangePasswordForm changePassword = new ChangePasswordForm();
                this.Close();
                changePassword.Show();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
