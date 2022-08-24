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
        SqlConnection conn = Classes.DataBaseConnectionClass.GetConnection();
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
                string query = "SELECT * FROM [Table]";
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
                    if (counter == 6)
                    {
                        // next line
                        buttonPoint = new Point(buttonPoint.X - 450, buttonPoint.Y + 45);
                        counter = 0;
                    }
                    tableButton.Location = new Point(buttonPoint.X + 75, buttonPoint.Y);
                    tableButton.Text = row["nr"].ToString();
                    panel1.Controls.Add(tableButton);
                    buttonPoint = tableButton.Location;
                    counter++;

                    bool isFree = Convert.ToBoolean(row["isFree"]);
                    if (tableButton.Text == "0")
                    {
                        tableButton.Text = "No table";
                        tableButton.BackColor = Color.LightGray;
                        tableButton.ForeColor = Color.Black;
                    }
                    else if (isFree)
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

                    tableButton.Click += new EventHandler(this.tableButton_Click);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            try
            {
                string tableNr = buttonClick.Text;
                if (tableNr == "0" || tableNr == "No table")
                {
                    MessageBox.Show("You cannot delete this table - it is mandatory.", "Button Select", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                tableNrTextBox.Text = tableNr;
                deleteTableButton.Enabled = true;
                addTableButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableNrTextBox.Text != "" && tableNrTextBox.Text != null && tableNrTextBox.Text != null)
                {
                    string tableNr = tableNrTextBox.Text;
                    bool isFree = true;
                    if (MessageBox.Show("Are you sure you want to add table number " + tableNr + "?", "Add Table", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (checkIsNotExistForAdd(tableNr))
                        {
                            addTable(tableNr, isFree);
                            this.Close();
                            Forms.AddEditTablesForm addEditTables = new AddEditTablesForm();
                            addEditTables.Show();
                        }
                        else
                        {
                            MessageBox.Show("This table has already been added.", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter table number.", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTable(string tableNr, bool isFree)
        {
            string query = "INSERT INTO [Table] (nr, isFree) VALUES (@nr, @isFree)";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@nr", tableNr);
            command.Parameters.AddWithValue("@isFree", isFree);
            conn.Open();
            int isSuccess = command.ExecuteNonQuery();
            conn.Close();
            if (isSuccess > 0)
                MessageBox.Show("Table added successfully.", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Table not added.", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool checkIsNotExistForAdd(string tableNr)
        {
            string query = "SELECT * FROM [Table] WHERE nr = @nr";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@nr", tableNr);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }

        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableNrTextBox.Text != "" && tableNrTextBox != null && tableNrTextBox.Text != null)
                {
                    string tableNr = tableNrTextBox.Text;
                    if (MessageBox.Show("Are you sure you want to delete table number " + tableNr + "?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (!checkIsNotExistForAdd(tableNr))
                        {
                            if (MessageBox.Show("When this table is deleted, the table in orders with this number will change to 'No table'. You are sure?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                deleteTable(tableNr);
                                this.Close();
                                Forms.AddEditTablesForm addEditTables = new AddEditTablesForm();
                                addEditTables.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can not delete a table that doesn't exist.", "Delete Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select table number.", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteTable(string tableNr)
        {
            string query = "[sp_delete_table]";
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@p_table_nr", tableNr);
            conn.Open();
            int isSuccess = command.ExecuteNonQuery();
            conn.Close();
            if (isSuccess > 0)
                MessageBox.Show("Table deleted successfully.", "Delete Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Table not deleted.", "Delete Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tableNrTextBox_TextChanged(object sender, EventArgs e)
        {
            string tableNr = tableNrTextBox.Text;
            foreach (char c in tableNr.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Please enter only table number.", "Table Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tableNrTextBox.Text = "";
                    return;
                }
            }

            addTableButton.Enabled = true;
            deleteTableButton.Enabled = false;
        }

        private void AddEditTablesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.Show();
        }
    }
}
