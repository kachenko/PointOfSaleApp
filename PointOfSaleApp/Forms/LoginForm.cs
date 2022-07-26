using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        
        public LoginForm()
        {
            InitializeComponent();
        }

		private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Login is requiered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loginTextBox.Focus();
            }
            if (passTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is requiered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                passTextBox.Focus();
            }

            string loginText = loginTextBox.Text;
            string passwordText = passTextBox.Text;
            bool isActive = false;

            string loginUserText = "";
            string passwordUserText = "";

            conn.Open();
            SqlCommand command = new SqlCommand("[sp_show_user]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_login", loginText);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                loginUserText = reader["login"].ToString();
                passwordUserText = reader["password"].ToString();
                isActive = bool.Parse(reader["isActive"].ToString());
            }
            else
            {
                MessageBox.Show("User does not exist.", "Validation Error", MessageBoxButtons.OK);
            }
            conn.Close();


            if (isActive == false)
            {
                MessageBox.Show("You don't have access. Contact the administrator.", "Validation Error", MessageBoxButtons.OK);
            }
            else
            {
                byte[] psw = System.Text.Encoding.Default.GetBytes(passwordUserText);
                if (Classes.CryptographyClass.MatchSHA1(psw, Classes.CryptographyClass.GetSHA1(loginText, passwordText)))
                {
                    getMyUserInfo(loginText);
                    MenuForm mf = new MenuForm();
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Login/password is incorrect!", "Validation Error", MessageBoxButtons.OK);
                }
            }
        }

        private void getMyUserInfo(string loginText)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("[sp_show_user]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_login", loginText);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MyUserClass.userId = int.Parse(reader["id"].ToString());
                MyUserClass.userLogin = reader["login"].ToString();
                MyUserClass.userPassword = reader["password"].ToString();
                MyUserClass.userFullName = reader["full_name"].ToString();
                MyUserClass.userAddress = reader["address"].ToString();
                MyUserClass.userPhone = reader["phone"].ToString();
                MyUserClass.userRoleId = int.Parse(reader["role_id"].ToString());
                MyUserClass.userRole = reader["role"].ToString();
                MyUserClass.userIsActive = bool.Parse(reader["isActive"].ToString());
            }
            conn.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void adminForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            Forms.ChangeAdminPasswordForm cap = new Forms.ChangeAdminPasswordForm();
            cap.ShowDialog();
        }
    }
}
