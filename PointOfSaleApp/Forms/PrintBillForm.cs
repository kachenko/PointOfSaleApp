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
    public partial class PrintBillForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");

        public PrintBillForm()
        {
            InitializeComponent();
        }

        private void PrintBillForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("[sp_bill_report]", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_order_id", OrderClass.orderId);
            conn.Open();
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            ReportDataSource dataSource = new ReportDataSource("billDataSet", table);
            billReportViewer.LocalReport.DataSources.Clear();
            billReportViewer.LocalReport.DataSources.Add(dataSource);
            billReportViewer.LocalReport.Refresh();
            this.billReportViewer.RefreshReport();
            conn.Close();
        }
    }
}
