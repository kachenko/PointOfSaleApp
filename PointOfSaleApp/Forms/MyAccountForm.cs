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
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        public MyAccountForm()
        {
            InitializeComponent();
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MyUserClass.userLogin.ToString();
            loadUserData();
        }

        private void loadUserData()
        {
            string query = "select * from [User] where id = " + MyUserClass.userId;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                userIDTextBox.Text = row["id"].ToString();
                userLoginTextBox.Text = row["login"].ToString();
                userFullNameTextBox.Text = row["full_name"].ToString();
                userAddressTextBox.Text = row["address"].ToString();
                userRoleTextBox.Text = row["role"].ToString();
                userIsActiveTextBox.Text = row["isActive"].ToString();

                userPictureBox.Image = MyUserClass.loadUserPicture();
            }
        }
        
        //static public Image loadUserPicture()
        //{
        //    byte[] getImage = new byte[0];
        //    SqlCommand command1 = new SqlCommand("select image from [User] where id = " + MyUserClass.userId, conn);
        //    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
        //    command1.CommandType = CommandType.Text;
        //    DataSet set = new DataSet();
        //    adapter1.Fill(set);
        //    foreach (DataRow dr in set.Tables[0].Rows)
        //    {
        //        getImage = (byte[])dr["image"];
        //    }
        //    byte[] imageData = getImage;
        //    MemoryStream memoryStream = new MemoryStream(imageData);
        //    return Image.FromStream(memoryStream);
        //}

        private bool ableEditUserData()
        {
            if (MessageBox.Show("Are you sure you want to edit your data?", "Data editing.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                userFullNameTextBox.Enabled = true;
                userAddressTextBox.Enabled = true;
                userPhoneTextBox.Enabled = true;
                if (MyUserClass.userRole == "Admin")
                {
                    userRoleTextBox.Enabled = true;
                }
                saveUserButton.Enabled = true;
                editUserButton.Enabled = false;
                return true;
            }
            return false;
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            ableEditUserData();
        }
        private void saveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //string query = "update [User] set login = @login, password = @password, full_name = @full_name, address = @address, phone = @phone, role = @role, image = @image where id = " + MyUserClass.userId;
                string query = "update [User] set login = '" + userLoginTextBox.Text + "'," +
                    "full_name = '" + userFullNameTextBox.Text + "', " + 
                    "address = '" + userAddressTextBox.Text + "', " +
                    "phone = '" + userPhoneTextBox.Text + "', " +
                    "role = '" + userRoleTextBox.Text + "', " +
                    "image = @image where id = " + MyUserClass.userId;
                SqlCommand command = new SqlCommand(query, conn);
                MemoryStream stream = new MemoryStream();
                userPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] setImage = stream.ToArray();
                command.Parameters.AddWithValue("@image", setImage);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            userFullNameTextBox.Enabled = false;
            userAddressTextBox.Enabled = false;
            userPhoneTextBox.Enabled = false;
            if (MyUserClass.userRole == "Admin")
            {
                userRoleTextBox.Enabled = false;
            }
            saveUserButton.Enabled = false;
            editUserButton.Enabled = true;
            MessageBox.Show("Your data updated", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            if (ableEditUserData())
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.Show();
        }

    }
}
