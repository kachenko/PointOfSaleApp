﻿using System;
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
    public partial class AddCategoryForm2 : Form
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-FBVOGLE\\SQLEXPRESS;initial catalog=posDB;integrated security=true");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public AddCategoryForm2()
        {
            InitializeComponent();
        }

        private void AddCategoryForm2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'posDBDataSet.Category' . Możesz go przenieść lub usunąć.
            this.categoryTableAdapter.Fill(this.posDBDataSet.Category);
            nameLabel.Text = MyUserClass.userLogin.ToString();
            positLabel.Text = MyUserClass.userRole.ToString();
        }

        private void ClearData()
        {
            prodCatIDTextBox.Text = "";
            prodCatTextBox.Text = "";
            prodCatDesTextBox.Text = "";
        }

        // Display Data in DataGridView
        private void DisplayData()
        {
            string query = "select * from Category";
            conn.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            categoryGridView.DataSource = table;
            conn.Close();
        }

        // Fill TextBoxes from DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prodCatIDTextBox.Text = categoryGridView.CurrentRow.Cells[0].Value.ToString();
            prodCatTextBox.Text = categoryGridView.CurrentRow.Cells[1].Value.ToString();
            prodCatDesTextBox.Text = categoryGridView.CurrentRow.Cells[2].Value.ToString();
        }

        // Helper
        private bool checkIfExistForAdd(string name)
        {
            DataTable table = new DataTable();
            string query = "select * from Category where name = @name";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to add category " + prodCatTextBox.Text + "?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (prodCatTextBox != null && prodCatDesTextBox != null)
                {
                    if (!checkIfExistForAdd(prodCatTextBox.Text))
                    {
                        string query = "insert into [Category] (name, description) values(@name, @description)";
                        cmd = new SqlCommand(query, conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@name", prodCatTextBox.Text);
                        cmd.Parameters.AddWithValue("@description", prodCatDesTextBox.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Category " + prodCatTextBox.Text + " added.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("You cannot add an existing category. Check the data you entered.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You did not provide data. Please check.");
                }
            }
        }

        // Helper
        private bool checkIfExistForUpdate(string id)
        {
            DataTable table = new DataTable();
            string query = "select * from Category where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void updateCategory()
        {
            if ((MessageBox.Show("Are you sure you want to update a category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                string queryUpdate = "update Category set name = @name, description = @description where id = " + prodCatIDTextBox.Text;
                SqlCommand command = new SqlCommand(queryUpdate, conn);
                conn.Open();
                command.Parameters.AddWithValue("@name", prodCatTextBox.Text);
                command.Parameters.AddWithValue("@description", prodCatDesTextBox.Text);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category " + prodCatTextBox.Text + " updated.", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                ClearData();
            }
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            if (checkIfExistForAdd(prodCatTextBox.Text))
            {
                MessageBox.Show("You have not made any changes.");
                return;
            }
            if (prodCatTextBox == null && prodCatDesTextBox == null)
            {
                MessageBox.Show("You did not provide data. Please check.");
                return;
            }
            if (checkIfExistForUpdate(prodCatIDTextBox.Text))
                updateCategory();
            else
            {
                MessageBox.Show("You cannot update a non-existent category. Check the data you entered.");
                return;
            }
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to remove category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                if (prodCatIDTextBox.Text != "0" && prodCatTextBox.Text != "" && prodCatDesTextBox.Text != "")
                {
                    string query = "delete from [Category] where id = @id";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", prodCatIDTextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category " + prodCatTextBox.Text + " deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("You did not select record to delete.");
                }
            }
        }

        private void prodCatTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void prodCatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(MessageBox.Show("Do you want to add the new category?", "Add/Edit Category", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            prodCatIDTextBox.Text = "0";
                        }
            */
        }

        private void AddCategoryForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you really want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}