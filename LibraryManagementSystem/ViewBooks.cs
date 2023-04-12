using LMS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ViewBooks : Form
    {
        SqlConnection cn;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        
        General general = new General();
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            general.logout(this);
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand comm = new SqlCommand("Select * From Books b  ORDER BY b.name", cn);
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4)
                    });
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
                    SqlCommand comm = new SqlCommand("Delete From Books WHERE id =" + id, cn);

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
                else
                {
                    Update update = new Update() {id = id};
                    update.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You can't delete or update this field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewBooks main = new ViewBooks();
            main.Show();
        }
    }
}
