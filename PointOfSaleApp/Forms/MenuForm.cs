using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if(MyUserClass.userRole == "Admin")
            {
                newOrderButton.Visible = true;
                myOrdersButton.Visible = true;
                menuButton.Visible = true;
                dishButton.Visible = true;
                categoryButton.Visible = true;
                usersButton.Visible = true;
                myAccountButton.Visible = true;
            }
            else if (MyUserClass.userRole == "Waiter")
            {
                newOrderButton.Visible = true;
                myOrdersButton.Visible = true;
                menuButton.Visible = true;
                dishButton.Visible = false;
                categoryButton.Visible = false;
                usersButton.Visible = false;
                myAccountButton.Visible = true;
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderForm nof = new NewOrderForm();
            this.Hide();
            nof.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(MessageBox.Show("Do you really want to exit? MenuForm", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Forms.AddDishForm addDish = new Forms.AddDishForm();
            this.Hide();
            addDish.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Forms.AddCategoryForm addCategory = new Forms.AddCategoryForm();
            this.Hide();
            addCategory.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.AddCategoryForm2 addCategory = new Forms.AddCategoryForm2();
            this.Hide();
            addCategory.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Forms.UsersManagementForm usersManagment = new Forms.UsersManagementForm();
            this.Hide();
            usersManagment.Show();
        }

        private void myAccountButton_Click(object sender, EventArgs e)
        {
            Forms.MyAccountForm myAccount = new Forms.MyAccountForm();
            this.Hide();
            myAccount.Show();
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            Forms.OrdersForm orders = new Forms.OrdersForm();
            this.Hide();
            orders.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            Forms.ReportsForm reports = new Forms.ReportsForm();
            this.Hide();
            reports.Show();
        }
    }
}
