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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        string defaultPassword = "12345";

        public ChangePasswordForm()
        {
            InitializeComponent();
            passwordTextBox.Text = defaultPassword;
            passwordTextBox.UseSystemPasswordChar = true;
            loadUserInfo(Classes.SelectedUserClass.userId);
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
            try
            {
                if (loginTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    Classes.SelectedUserClass.userPassword = Classes.CryptographyClass.Encrypt(passwordTextBox.Text);
                    string query = "UPDATE [User] SET password = '" + Classes.SelectedUserClass.userPassword + "' where id = " + int.Parse(userIDTextBox.Text);

                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User password updated successfully", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
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
