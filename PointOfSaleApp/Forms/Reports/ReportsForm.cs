using PointOfSaleApp.Forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void perDayButton_Click(object sender, EventArgs e)
        {
            PrintReportPerDay perDay = new PrintReportPerDay();
            perDay.ShowDialog();
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.Show();
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
            if (MessageBox.Show("You want to return.\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForReportsForm infoForReports = new InfoForReportsForm();
            infoForReports.ShowDialog();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
        }

        private void perMonthButton_Click(object sender, EventArgs e)
        {
            Forms.Reports.PrintReportPerMonth perMonth = new Reports.PrintReportPerMonth();
            perMonth.Show();
        }

        private void perYearButton_Click(object sender, EventArgs e)
        {
            Forms.Reports.PrintReportPerYear perYear = new Reports.PrintReportPerYear();
            perYear.Show();
        }
    }
}
