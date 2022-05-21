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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        
        public LoginForm()
        {
            InitializeComponent();
        }

		private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("sp_role_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@login", LoginTextBox.Text);
            command.Parameters.AddWithValue("@password", passTextBox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (LoginTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Login is requiered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoginTextBox.Focus();
            }
            if (passTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is requiered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                passTextBox.Focus();
            }
            if (table.Rows.Count == 1)
            {
                foreach(DataRow row in table.Rows)
                {
                    MyUserClass.userId = int.Parse(row["id"].ToString());
                    MyUserClass.userLogin = row["login"].ToString();
                    MyUserClass.userRole = row["role"].ToString();
                }
                MenuForm mf = new MenuForm();
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Login/password is incorrect!", "Validation Error", MessageBoxButtons.OK);
                LoginTextBox.Focus();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit? LoginForm", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
