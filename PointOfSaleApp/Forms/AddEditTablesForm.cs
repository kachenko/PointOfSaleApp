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
    public partial class AddEditTablesForm : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        public AddEditTablesForm()
        {
            InitializeComponent();
            loadTables();
        }

        private void loadTables()
        {
            try
            {
                // count buttons
                int counter = 0;
                Point buttonPoint = new Point(-70, 0);
                string query = "select * from [Table]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Button tableButton = new Button();
                    tableButton.Size = new Size(70, 40);
                    tableButton.Font = new Font("Malgun Gothic", 8, FontStyle.Regular);
                    tableButton.FlatStyle = FlatStyle.Flat;
                    if (counter == 3)
                    {
                        // next line
                        buttonPoint = new Point(buttonPoint.X - 12, buttonPoint.Y + 133);
                        counter = 0;
                    }
                    tableButton.Location = new Point(buttonPoint.X + 75, buttonPoint.Y);
                    tableButton.Text = row["nr"].ToString();
                    tableButton.Controls.Add(tableButton);
                    buttonPoint = tableButton.Location;
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
