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
    public partial class OrderTableForm : Form
    {
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
        public OrderTableForm()
        {
            InitializeComponent();
        }

        private void OrderTableForm_Load(object sender, EventArgs e)
        {
            loadTables();
        }

        private void loadTables()
        {
            Point buttonPoint = new Point(100, 15);

            string query = "select * from [Table]";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                this.Size = new Size(this.Width + 60, this.Height);
                Button tableButton = new Button();
                tableButton.Name = row["nr"].ToString();
                tableButton.Text = row["nr"].ToString();
                tableButton.Size = new Size(55, 55);
                tableButton.Location = new Point(buttonPoint.X + 60, buttonPoint.Y);
                try
                {
                    if (row["nr"].ToString() == "0")
                    {
                        tableButton.BackColor = Color.LightGray;
                        tableButton.ForeColor = Color.Black;
                    }
                    else if (Convert.ToBoolean(row["isFree"]))
                    {
                        tableButton.BackColor = Color.Green;
                        tableButton.ForeColor = Color.White;
                    }
                    else
                    {
                        tableButton.BackColor = Color.Red;
                        tableButton.ForeColor = Color.White;
                        tableButton.Enabled = false;
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Controls.Add(tableButton);
                    buttonPoint = tableButton.Location;

                    tableButton.Click += new EventHandler(this.tableButtonClick);
                }
            }
        }

        private void tableButtonClick(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            // select this button
            try
            {
                OrderClass.orderTableNr = int.Parse(buttonClick.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(MessageBox.Show("Table " + buttonClick.Name + " is select.", "Table is select", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void OrderTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("If you turned off the form, then automatically the selected table number will be 0, which means 'No table'.", "Table is select", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
