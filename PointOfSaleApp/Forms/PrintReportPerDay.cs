using Microsoft.Reporting.WinForms;
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

namespace PointOfSaleApp.Forms
{
    public partial class PrintReportPerDay : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public PrintReportPerDay()
        {
            InitializeComponent();
        }

        private void PrintReportPerDay_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("[sp_day_report]", conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                ReportDataSource dataSource = new ReportDataSource("dailyReportDataSet", table);
                dailyReportViewer.LocalReport.DataSources.Clear();
                dailyReportViewer.LocalReport.DataSources.Add(dataSource);
                dailyReportViewer.LocalReport.Refresh();
                this.dailyReportViewer.RefreshReport();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
