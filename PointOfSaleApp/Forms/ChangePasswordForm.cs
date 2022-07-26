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
    public partial class ChangePasswordForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        string defaultPassword = "12345";

        public ChangePasswordForm()
        {
            InitializeComponent();
            passwordTextBox.Text = defaultPassword;
            passwordTextBox.UseSystemPasswordChar = true;
            loadUserInfo(Classes.UserClass.userId);
        }

        public void loadUserInfo(int id)
        {
            string query = "select id, login from [User] where id = " + id;
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                userIDTextBox.Text = row["id"].ToString();
                loginTextBox.Text = row["login"].ToString();
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void setDefaultButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = defaultPassword;
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            string passwordText = passwordTextBox.Text;
            string loginText = loginTextBox.Text;
            try
            {
                if (loginTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    passwordText = System.Text.Encoding.Default.GetString(Classes.CryptographyClass.GetSHA1(loginText, passwordText)); // Classes.CryptographyClass.GetSHA1(loginTextBox.Text, passwordTextBox.Text).ToString(); //.Encrypt(passwordTextBox.Text);
                    conn.Open();
                    SqlCommand command = new SqlCommand("[sp_update_user_password]", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_id", int.Parse(userIDTextBox.Text));
                    command.Parameters.AddWithValue("@p_password", passwordText);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User password updated successfully.", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all the fields.", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
