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
            Forms.AddProductForm addProduct = new Forms.AddProductForm();
            this.Hide();
            addProduct.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Forms.AddCategoryForm addCategory = new Forms.AddCategoryForm();
            this.Hide();
            addCategory.Show();
        }
    }
}
