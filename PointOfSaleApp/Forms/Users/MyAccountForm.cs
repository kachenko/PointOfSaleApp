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
    public partial class MyAccountForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        public MyAccountForm()
        {
            InitializeComponent();
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                nameLabel.Text = MyUserClass.userLogin.ToString();
                loadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadUserData()
        {
            userIDTextBox.Text = MyUserClass.userId.ToString();
            userLoginTextBox.Text = MyUserClass.userLogin;
            userFullNameTextBox.Text = MyUserClass.userFullName;
            userAddressTextBox.Text = MyUserClass.userAddress;
            loadRoleComboBox();
            userRoleComboBox.SelectedValue = MyUserClass.userRoleId;
            userIsActiveTextBox.Text = MyUserClass.userIsActive.ToString();
            userPictureBox.Image = MyUserClass.loadUserImage();
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

        private void ableEditUserData()
        {
            userFullNameTextBox.Enabled = true;
            userAddressTextBox.Enabled = true;
            userPhoneTextBox.Enabled = true;
            if (MyUserClass.userRoleId == 1)
                userRoleComboBox.Enabled = true;
            saveUserButton.Enabled = true;
            editUserButton.Enabled = false;
        }

    private void editUserButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to edit your data?", "Data editing.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                ableEditUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

        private void saveUserData()
        {
            DataRowView dataRow = userRoleComboBox.SelectedItem as DataRowView;

            string p_login;
            if (userLoginTextBox.Text == null || userLoginTextBox.Text == "")
                p_login = null;
            else
                p_login = userLoginTextBox.Text;

            string p_full_name;
            if (userFullNameTextBox.Text == null || userFullNameTextBox.Text == "")
                p_full_name = null;
            else
                p_full_name = userFullNameTextBox.Text;

            string p_address;
            if (userAddressTextBox.Text == null || userAddressTextBox.Text == "")
                p_address = null;
            else
                p_address = userAddressTextBox.Text;


            string p_phone;
            if (userPhoneTextBox.Text == null || userPhoneTextBox.Text == "")
                p_phone = null;
            else
                p_phone = userPhoneTextBox.Text;

            int p_roleID = int.Parse(dataRow.Row["id"].ToString()); 
            if (p_roleID == 0)
                p_roleID = 4;

            MemoryStream stream = new MemoryStream();
            userPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] setImage = stream.ToArray();

            SqlCommand command = new SqlCommand("[sp_update_user]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_user_id", MyUserClass.userId);
            command.Parameters.AddWithValue("@p_login", p_login);
            command.Parameters.AddWithValue("@p_full_name", p_full_name);
            command.Parameters.AddWithValue("@p_address", p_address);
            command.Parameters.AddWithValue("@p_phone", p_phone);
            command.Parameters.AddWithValue("@p_role_id", p_roleID);
            command.Parameters.AddWithValue("@p_image", setImage);
            int isSuccess = command.ExecuteNonQuery();

            if (isSuccess == 1)
                MessageBox.Show("Your data updated.", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your data is not updated.", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save your data?", "Data editing.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    saveUserData();
                    conn.Close();

                    userFullNameTextBox.Enabled = false;
                    userAddressTextBox.Enabled = false;
                    userPhoneTextBox.Enabled = false;
                    if (MyUserClass.userRoleId == 1)
                        userRoleComboBox.Enabled = false;
                    saveUserButton.Enabled = false;
                    editUserButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit your data?", "Data editing.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                ableEditUserData();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
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
