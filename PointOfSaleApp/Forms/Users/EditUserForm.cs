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
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        byte[] setImage = null;

        public EditUserForm()
        {
            InitializeComponent();
            loadUserData();
        }

        private void loadUserData()
        {
            try
            {
                int userID = Classes.UserClass.userId;
                int id = userID;
                userIDTextBox.Text = id.ToString();
                userFullNameTextBox.Text = Classes.UserClass.userFullName;
                userLoginTextBox.Text = Classes.UserClass.userLogin;
                userAddressTextBox.Text = Classes.UserClass.userAddress;
                userPhoneTextBox.Text = Classes.UserClass.userPhone;
                loadRoleComboBox();
                var myRole = userRoleComboBox.Items.Cast<Object>()
                               .Where(x => userRoleComboBox.GetItemText(x).Equals(Classes.UserClass.userRole))
                               .FirstOrDefault();
                userRoleComboBox.SelectedItem = myRole;
                userPictureBox.Image = Classes.UserClass.loadUserPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadRoleComboBox()
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

                        MemoryStream stream2 = new MemoryStream();
                        userPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        setImage = stream2.ToArray();
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
                        int p_userID = int.Parse(userIDTextBox.Text.ToString());

                        string p_userLogin;
                        if (userLoginTextBox.Text == null || userLoginTextBox.Text == "")
                            p_userLogin = null;
                        else
                            p_userLogin = userLoginTextBox.Text;

                        string p_userFullName;
                        if (userFullNameTextBox.Text == null || userFullNameTextBox.Text == "")
                            p_userFullName = null;
                        else
                            p_userFullName = userFullNameTextBox.Text;

                        string p_userAddress;
                        if (userAddressTextBox.Text == null || userAddressTextBox.Text == "")
                            p_userAddress = null;
                        else
                            p_userAddress = userAddressTextBox.Text;

                        string p_userPhone;
                        if (userPhoneTextBox.Text == null || userPhoneTextBox.Text == "")
                            p_userPhone = null;
                        else
                            p_userPhone = userPhoneTextBox.Text;

                        SqlCommand command = new SqlCommand("[sp_update_user]", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_user_id", p_userID);
                        command.Parameters.AddWithValue("@p_login", p_userLogin);
                        command.Parameters.AddWithValue("@p_full_name", p_userFullName);
                        command.Parameters.AddWithValue("@p_address", p_userAddress);
                        command.Parameters.AddWithValue("@p_phone", p_userPhone);
                        DataRowView dataRow = userRoleComboBox.SelectedItem as DataRowView;
                        int roleID = int.Parse(dataRow.Row["id"].ToString());
                        command.Parameters.AddWithValue("@p_role_id", roleID);

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

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
