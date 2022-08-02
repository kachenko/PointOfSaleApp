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
            try
            {
                InitializeComponent();
                loadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

        private void loadUsers()
        {
            dataUsersGridView.Rows.Clear();
            dataUsersGridView.Refresh();
            string query = "SELECT * FROM VAllUsersList";
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataUsersGridView.ColumnCount = 7;
            dataUsersGridView.Columns[0].Name = "ID";
            dataUsersGridView.Columns[1].Name = "Login";
            dataUsersGridView.Columns[2].Name = "FullName";
            dataUsersGridView.Columns[3].Name = "Address";
            dataUsersGridView.Columns[4].Name = "Phone";
            dataUsersGridView.Columns[5].Name = "IsActive";
            dataUsersGridView.Columns[6].Name = "Role";

            foreach (DataRow row in table.Rows)
            {
                string[] dataGridViewRow = new string[]
                    { row["ID"].ToString(), row["Login"].ToString(), row["FullName"].ToString(), row["Address"].ToString(), row["Phone"].ToString(), row["IsActive"].ToString(), row["Role"].ToString() };
                dataUsersGridView.Rows.Add(dataGridViewRow);
            }
            conn.Close();
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
                getUserInfo();
                
                Forms.ChangePasswordForm changePassword = new ChangePasswordForm();
                changePassword.ShowDialog();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getUserInfo()
        {
            int selectedIndex = dataUsersGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataUsersGridView.Rows[selectedIndex];
            int userID = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            string query = "SELECT * FROM [User] WHERE id = @p_id";

            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@p_id", userID);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Classes.UserClass.userId = int.Parse(row["id"].ToString());
                Classes.UserClass.userLogin = row["login"].ToString();
                Classes.UserClass.userFullName = row["full_name"].ToString();
                Classes.UserClass.userAddress = row["address"].ToString();
                Classes.UserClass.userPhone = row["phone"].ToString();
                Classes.UserClass.IsActive = bool.Parse(row["isActive"].ToString());
            }
            Classes.UserClass.userRole = selectedRow.Cells["Role"].Value.ToString();
            
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                getUserInfo();

                Forms.EditUserForm editUser = new EditUserForm();
                editUser.ShowDialog();
                loadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataUsersGridView.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete a new user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("[sp_delete_user]", conn); 
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        getUserInfo();
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
                Classes.UserClass.clearSelectedUser();
                loadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
