using LibraryManagementSystem;
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

namespace LMS
{
    public partial class Genres : Form
    {
        SqlConnection cn;
        SqlDataReader rdr;
        SqlCommand cmd;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        General general = new General();
        public Genres()
        {
            InitializeComponent();
        }

        private void Genres_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            cmd = new SqlCommand("Select * From Genres g  ORDER BY g.name", cn);
            using (rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        rdr.GetValue(0),
                        rdr.GetValue(1)
                    });
                }
            }
        }

        private void addGenresButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter genre name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("select * from Genres where name = '" + nameTextBox.Text + "'", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())  // validate from table
                {
                    rdr.Close();
                    MessageBox.Show("Genre already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rdr.Close();
                    cmd = new SqlCommand("INSERT INTO Genres (name) VALUES(@nameTextbox);", cn);
                    cmd.Parameters.AddWithValue("nameTextbox", nameTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Genra saved succssfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    general.ClearAll(this);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = this.dataGridView1.Columns[e.ColumnIndex].Name;
            cn = new SqlConnection(connectionString);
            cn.Open();
            int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (id > 0)
            {
                if (columnName.Equals("delete"))
                {
                    SqlCommand comm = new SqlCommand("Delete From Genres WHERE id =" + id, cn);

                    if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Genres genres = new Genres();
            genres.Show();
        }
    }
}
