using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp.Forms
{
    public partial class EditUserForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public EditUserForm()
        {
            InitializeComponent();
            loadUserData();
        }

        private void loadUserData()
        {
            try
            {
                string query = "select u.*, ur.name [role] from [User] u join [UserRole] ur on u.role_id = ur.id where u.id = " + Classes.UserClass.userId + " order by 1";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                conn.Close();

                foreach (DataRow row in table.Rows)
                {
                    int id = Convert.ToInt32(row["id"].ToString());
                    userIDTextBox.Text = id.ToString();
                    userFullNameTextBox.Text = row["full_name"].ToString();
                    userLoginTextBox.Text = row["login"].ToString();
                    userAddressTextBox.Text = row["address"].ToString();
                    userPhoneTextBox.Text = row["phone"].ToString();
                    // userRoleTextBox.Text = row["role"].ToString();
                    loadRoleComboBox();
                    var myRole = userRoleComboBox.Items.Cast<Object>()
                                   .Where(x => userRoleComboBox.GetItemText(x).Equals(Classes.UserClass.userRole))
                                   .FirstOrDefault();
                    userRoleComboBox.SelectedItem = myRole;
                    userPictureBox.Image = Classes.UserClass.loadUserPicture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadRoleComboBox()
        {
            try
            {
                string query = "select id, name from [UserRole]";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                userRoleComboBox.DataSource = table;
                userRoleComboBox.DisplayMember = "name";
                userRoleComboBox.ValueMember = "id";
                userRoleComboBox.Enabled = true;

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
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

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = open.OpenFile()) != null)
                    {
                        string fileName = open.FileName;
                        if (stream.Length > 512000)
                            MessageBox.Show("File Size limit exceeded", "Picture Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            userPictureBox.Load(fileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userLoginTextBox.Text != "" && userRoleComboBox.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to edit user?", "Edit User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("[sp_update_user]", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_user_id", userIDTextBox.Text);
                        command.Parameters.AddWithValue("@p_login", userLoginTextBox.Text);
                        command.Parameters.AddWithValue("@p_full_name", userFullNameTextBox.Text);
                        command.Parameters.AddWithValue("@p_address", userAddressTextBox.Text);
                        command.Parameters.AddWithValue("@p_phone", userPhoneTextBox.Text);
                        DataRowView dataRow = userRoleComboBox.SelectedItem as DataRowView;
                        int roleID = int.Parse(dataRow.Row["id"].ToString());
                        command.Parameters.AddWithValue("@p_role_id", roleID);

                        MemoryStream stream = new MemoryStream();
                        userPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] setImage = stream.ToArray();
                        command.Parameters.AddWithValue("@p_image", setImage);

                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("User edited successfully", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter requaired details.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void changePasswdButton_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.UserClass.userId = int.Parse(userIDTextBox.Text);
                Classes.UserClass.userLogin = userLoginTextBox.Text;

                Forms.ChangePasswordForm changePassword = new ChangePasswordForm();
                changePassword.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
