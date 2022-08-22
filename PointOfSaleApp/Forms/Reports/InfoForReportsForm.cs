using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp.Forms.Reports
{
    public partial class InfoForReportsForm : Form
    {
        public InfoForReportsForm()
        {
            InitializeComponent();
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
            this.Hide();
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            Classes.RestaurantClass.Name = restaurantNameTextBox.Text;
            Classes.RestaurantClass.Address = restaurantAddressTextBox.Text;
            this.Hide();
        }

        private void InfoForReportsForm_Load(object sender, EventArgs e)
        {
            restaurantNameTextBox.Text = Classes.RestaurantClass.Name;
            restaurantAddressTextBox.Text = Classes.RestaurantClass.Address;
        }
    }
}
