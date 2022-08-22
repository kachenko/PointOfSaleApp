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
    public partial class AddUserForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        byte[] setImage = null;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userLoginTextBox.Text != "" && userPasswordTextBox.Text != "" && userRoleComboBox.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to add a new user?", "Add User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string loginText = userLoginTextBox.Text;
                        string passwordText = userPasswordTextBox.Text;
                        passwordText = System.Text.Encoding.Default.GetString(Classes.CryptographyClass.GetSHA1(loginText, passwordText)); 

                        SqlCommand command = new SqlCommand("[sp_add_user]", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_login", userLoginTextBox.Text);
                        command.Parameters.AddWithValue("@p_password", passwordText);
                        command.Parameters.AddWithValue("@p_full_name", userFullNameTextBox.Text);
                        command.Parameters.AddWithValue("@p_address", userAddressTextBox.Text);
                        command.Parameters.AddWithValue("@p_phone", userPhoneTextBox.Text);

                        DataRowView dataRow = userRoleComboBox.SelectedItem as DataRowView;
                        int roleID = int.Parse(dataRow.Row["id"].ToString());
                        command.Parameters.AddWithValue("@p_role_id", roleID);

                        command.Parameters.AddWithValue("@p_image", setImage);

                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("User added successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter details.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        MemoryStream stream2 = new MemoryStream();
                        userPictureBox.Image.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] setImage = stream2.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            loadRoleComboBox();
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
