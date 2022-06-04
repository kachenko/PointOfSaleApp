﻿using System;
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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userLoginTextBox.Text != "" && userPasswordTextBox.Text != "" && userRoleTextBox.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to add a new user?", "Add User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Classes.SelectedUserClass.userPassword = Classes.CryptographyClass.Encrypt(userPasswordTextBox.Text);

                        SqlCommand command = new SqlCommand("[sp_add_user]", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_login", userLoginTextBox.Text);
                        command.Parameters.AddWithValue("@p_password", userPasswordTextBox.Text);
                        command.Parameters.AddWithValue("@p_full_name", userFullNameTextBox.Text);
                        command.Parameters.AddWithValue("@p_address", userAddressTextBox.Text);
                        command.Parameters.AddWithValue("@p_phone", userPhoneTextBox.Text);
                        command.Parameters.AddWithValue("@p_role", userRoleTextBox.Text);

                        MemoryStream stream = new MemoryStream();
                        userPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] setImage = stream.ToArray();
                        command.Parameters.AddWithValue("@p_image", setImage);

                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("User added successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Forms.UsersManagementForm usersManagement = new UsersManagementForm();
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
