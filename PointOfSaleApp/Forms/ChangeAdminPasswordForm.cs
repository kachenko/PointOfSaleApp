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
    public partial class ChangeAdminPasswordForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        string defaultPassword = "12345";

        public ChangeAdminPasswordForm()
        {
            InitializeComponent();
            passwordTextBox.Text = repeatPassTextBox.Text = defaultPassword;
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            string loginText = loginTextBox.Text;
            string passwordText = passwordTextBox.Text;
            string repeatPasswordText = repeatPassTextBox.Text;
            int userID = 0;
            int roleID = 0;

            try
            {
                if (loginText != "" && passwordText != "")
                {
                    if (passwordText.Equals(repeatPasswordText))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("[sp_show_user]", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_login", loginText);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            userID = int.Parse(reader["id"].ToString());
                            roleID = int.Parse(reader["role_id"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("User is not found. Check the data.", "Change Admin Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            passwordTextBox.Focus();
                            conn.Close();
                            return;
                        }
                        conn.Close();

                        if (checkIsAdmin(roleID))
                        {
                            updateAdminPassword(userID, loginText, passwordText);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but you are not an administrator. Contact your administrator to change your password.", "Change Admin Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields.", "Change Admin Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateAdminPassword(int userID, string loginText, string passwordText)
        {
            passwordText = System.Text.Encoding.Default.GetString(Classes.CryptographyClass.GetSHA1(loginText, passwordText));
            conn.Open();
            SqlCommand command = new SqlCommand("[sp_update_user_password]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_id", userID);
            command.Parameters.AddWithValue("@p_password", passwordText);
            int isSuccess = command.ExecuteNonQuery();
            if (isSuccess == 1)
                MessageBox.Show("User password updated successfully.", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ERROR!\nThe user password has not been updated.", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
        }

        private bool checkIsAdmin(int roleID)
        {
            if (roleID == 1)
            {
                return true;
            }
            return false;
        }

        private void setDefaultButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = repeatPassTextBox.Text = defaultPassword;
            // repeatPassTextBox.Text = defaultPassword;
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                repeatPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                repeatPassTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
