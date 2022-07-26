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
                string query = "select u.*, ur.name [role] from [User] u join [UserRole] ur on u.role_id = ur.id order by 1";
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
            Forms.AddUserForm addUser = new AddUserForm();
            addUser.ShowDialog();

            loadUsers();
        }

        private void changePasswdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataUsersGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataUsersGridView.Rows[selectedIndex];
                Classes.UserClass.userId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                Classes.UserClass.userLogin = selectedRow.Cells["login"].Value.ToString();

                Forms.ChangePasswordForm changePassword = new ChangePasswordForm();
                changePassword.ShowDialog();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataUsersGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataUsersGridView.Rows[selectedIndex];
                Classes.UserClass.userId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                Classes.UserClass.userLogin = selectedRow.Cells["login"].Value.ToString();
                Classes.UserClass.userRole = selectedRow.Cells["role"].Value.ToString();

                Forms.EditUserForm editUser = new EditUserForm();
                editUser.ShowDialog();
                loadUsers();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataUsersGridView.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete a new user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("[sp_delete_user]", conn); 
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        int selectedIndex = dataUsersGridView.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataUsersGridView.Rows[selectedIndex];
                        Classes.UserClass.userId = int.Parse(selectedRow.Cells["id"].Value.ToString());
                        command.Parameters.AddWithValue("@p_user_id", Classes.UserClass.userId);
                        conn.Open();
                        int isDelete = command.ExecuteNonQuery();
                        if (isDelete > 0)
                        {
                            MessageBox.Show("User deleted.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not deleted - an error occurred.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select data.", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                clearSelectedUser();
                loadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearSelectedUser()
        {
            Classes.UserClass.userId = 0;
            Classes.UserClass.userLogin = null;
            Classes.UserClass.userPassword = null;
            Classes.UserClass.userRole = null;
        }
    }
}
