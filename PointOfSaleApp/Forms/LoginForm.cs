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

namespace PointOfSaleApp
{
    public partial class LoginForm : Form
    {
        SqlConnection cn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        
        public LoginForm()
        {
            cn.Open();
            InitializeComponent();
        }

		private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "select * from [User] where login = '" + LoginTextBox.Text + "' and password = '" + passTextBox.Text + "'";

            SqlDataAdapter adp = new SqlDataAdapter(query, cn);
            DataTable table = new DataTable();
            adp.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                int id = int.Parse(row["id"].ToString());
                string login = row["login"].ToString();
                string role = row["role"].ToString();

                UserClass.userId = id;
                UserClass.userLogin = login;
                UserClass.userRole = role;
            }

            int id2 = UserClass.userId;

            if (table.Rows.Count == 1)
            {
                MenuForm mf = new MenuForm();
                this.Hide();
                mf.Show();
            }
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
            if (LoginTextBox.Text != "admin" || passTextBox.Text != "admin")
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
