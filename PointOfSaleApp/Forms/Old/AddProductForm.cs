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
    public partial class AddProductForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        SqlDataAdapter adapter;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
            FillUnitComboBox();
            FillListProdView();
        }

        private void FillCategoryComboBox()
        {
            //conn.Open();
            //string query = "select * from [ProductCategory]";
            //adapter = new SqlDataAdapter(query, conn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DataRow row = table.NewRow();
            //row["name"] = "";
            //table.Rows.InsertAt(row, 0);
            //prodCatComboBox.DataSource = table;
            //prodCatComboBox.DisplayMember = "name";
            //prodCatComboBox.ValueMember = "id";
            //conn.Close();
        }
        private void FillUnitComboBox()
        {
            //conn.Open();
            //string query = "select * from [Unit]";
            //adapter = new SqlDataAdapter(query, conn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DataRow row = table.NewRow();
            //row["type"] = "";
            //table.Rows.InsertAt(row, 0);
            //prodUnitComboBox.DataSource = table;
            //prodUnitComboBox.DisplayMember = "type";
            //prodUnitComboBox.ValueMember = "id";
            //conn.Close();
        }

        private void FillListProdView()
        {
            //prodListView.Items.Clear();
            //prodListView.View = View.Details;
            //adapter = new SqlDataAdapter("select * from [Product]", conn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    DataRow row = table.Rows[i];
            //    ListViewItem item = new ListViewItem(row["id"].ToString());
            //    item.SubItems.Add(row["name"].ToString());
            //    item.SubItems.Add(row["category_id"].ToString());
            //    item.SubItems.Add(row["code"].ToString());
            //    item.SubItems.Add(row["unit_id"].ToString());
            //    prodListView.Items.Add(item);
            //}
        }


        private void addProductButton_Click(object sender, EventArgs e)
        {

        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit? NewOrderForm", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
