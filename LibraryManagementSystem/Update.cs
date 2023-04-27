using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LMS
{
    public partial class Update : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public int id;

        public Update()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty &&
               comboBox1.Text != string.Empty && textBox3.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from Books where name = '" + textBox1.Text + "' and author = '" + textBox2.Text + "'  and category = '" + comboBox1.Text + "' and count = " + textBox3.Text, cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())  // validate from table
                {
                    dr.Close();
                    MessageBox.Show("Books already exists in Library.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Control control in this.Controls)
                    {
                        // Set focus on control
                        control.Focus();
                        // Validate causes the control's Validating event to be fired,
                        // if CausesValidation is True
                        if (!Validate())
                        {
                            dr.Close();
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }

                    dr.Close();
                    cmd = new SqlCommand("UPDATE Books SET name = @booksNameTextbox, author = @booksAuthorTextBox, category = @bookCategoryDropDown, count = @bookCountTextBox WHERE id = " + id, cn);
                    cmd.Parameters.AddWithValue("booksNameTextbox", textBox1.Text);
                    cmd.Parameters.AddWithValue("booksAuthorTextBox", textBox2.Text);
                    cmd.Parameters.AddWithValue("bookCategoryDropDown", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("bookCountTextBox", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book data updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand comm = new SqlCommand("Select * From Books where id =" + id, cn);

            SqlDataReader DR1 = comm.ExecuteReader();
            if (DR1.Read())
            {
                string id = DR1.GetValue(0).ToString();
                textBox1.Text = DR1.GetValue(1).ToString();
                textBox2.Text = DR1.GetValue(2).ToString();
                comboBox1.Text = DR1.GetValue(3).ToString();
                textBox3.Text = DR1.GetValue(4).ToString();
            }
            cn.Close();
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d+"))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Count must be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }
    }
}
