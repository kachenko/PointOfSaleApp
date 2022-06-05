﻿using System;
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
            //DataTable table = new DataTable();
            //SqlCommand command = new SqlCommand("sp_role_login", conn);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@login", LoginTextBox.Text);
            //command.Parameters.AddWithValue("@password", passTextBox.Text);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(table);
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

            // string password = "";
            bool isExist = false;
            conn.Open();
            string query = "select u.*, ur.name [role] from [User] u join [UserRole] ur on u.role_id = ur.id where login = '" + LoginTextBox.Text + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MyUserClass.userId = int.Parse(reader["id"].ToString());
                MyUserClass.userLogin = reader["login"].ToString();
                MyUserClass.userPassword = reader["password"].ToString();
                MyUserClass.userFullName = reader["full_name"].ToString();
                MyUserClass.userRoleId = int.Parse(reader["role_id"].ToString());
                MyUserClass.userRole = reader["role"].ToString();
                MyUserClass.userIsActive = bool.Parse(reader["isActive"].ToString());
                // password = reader.GetString(2);
                isExist = true;
            }
            conn.Close();
            if (isExist)
            {
                if (Classes.CryptographyClass.Decrypt(MyUserClass.userPassword).Equals(passTextBox.Text))
                {
                    MenuForm mf = new MenuForm();
                    this.Hide();
                    mf.Show();
                }
                else if (MyUserClass.userIsActive == false)
                {
                    MessageBox.Show("You don't have access. Contact the administrator.", "Validation Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Login/password is incorrect!", "Validation Error", MessageBoxButtons.OK);
                }
            }
            
            //if (table.Rows.Count == 1)
            //{
            //    foreach(DataRow row in table.Rows)
            //    {
            //        MyUserClass.userId = int.Parse(row["id"].ToString());
            //        MyUserClass.userLogin = row["login"].ToString();
            //        MyUserClass.userPassword = row["password"].ToString();
            //        MyUserClass.userFullName = row["full_name"].ToString();
            //        MyUserClass.userRole = row["role"].ToString();
            //    }
            //    MenuForm mf = new MenuForm();
            //    this.Hide();
            //    mf.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Login/password is incorrect!", "Validation Error", MessageBoxButtons.OK);
            //    LoginTextBox.Focus();
            //}
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
