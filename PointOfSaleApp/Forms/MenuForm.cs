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
            loginLabel.Text = MyUserClass.userLogin;
            positLabel.Text = MyUserClass.userRole;
            accessToButtons();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void accessToButtons()
        {
            if (MyUserClass.userRoleId == 1)
            {
                newOrderButton.Visible = true;
                myOrdersButton.Visible = true;
                menuButton.Visible = true;
                dishButton.Visible = true;
                categoryButton.Visible = true;
                usersButton.Visible = true;
                myAccountButton.Visible = true;
                reportsButton.Visible = true;
            }
            else
            {
                newOrderButton.Visible = true;
                myOrdersButton.Visible = true;
                menuButton.Visible = true;
                dishButton.Visible = false;
                categoryButton.Visible = false;
                usersButton.Visible = false;
                myAccountButton.Visible = true;
                reportsButton.Visible = false;
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
                if(MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Forms.DishesMenuForm dishesMenu = new Forms.DishesMenuForm();
            this.Hide();
            dishesMenu.Show();
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

        private void tablesButton_Click(object sender, EventArgs e)
        {
            Forms.AddEditTablesForm addEditTables = new Forms.AddEditTablesForm();
            this.Hide();
            addEditTables.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (MessageBox.Show("You want to return.\nAre you sure you want to end your session?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                MyUserClass.ClearMyUser();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
