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

namespace PointOfSaleApp.Forms.Reports
{
    public partial class PrintReportPerMonth : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        public PrintReportPerMonth()
        {
            InitializeComponent();
        }

        private void PrintReportPerMonth_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [VMonthReport]", conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                ReportDataSource dataSource = new ReportDataSource("DataSet1", table);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("ReportUserLoginParameter", MyUserClass.userLogin));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
