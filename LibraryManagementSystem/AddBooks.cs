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

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public AddBooks()
        {
            InitializeComponent();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            if (booksNameTextbox.Text != string.Empty || booksAuthorTextBox.Text != string.Empty ||
                bookCountTextBox.Text != string.Empty || bookCategoryDropDown.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from Books where name = '" + booksNameTextbox.Text + "' and author = '" + booksAuthorTextBox.Text + "'  and category = '" + bookCategoryDropDown.Text + "'", cn);
                //cmd = new SqlCommand("select * from Books where username='" + regUsernameTextBox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())  // validate from table
                {
                    dr.Close();
                    MessageBox.Show("Books already exists in Library.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("INSERT INTO Books (name, author, category, count) VALUES(@booksNameTextbox, @booksAuthorTextBox, @bookCategoryDropDown, @bookCountTextBox);", cn);
                    cmd.Parameters.AddWithValue("booksNameTextbox", booksNameTextbox.Text);
                    cmd.Parameters.AddWithValue("booksAuthorTextBox", booksAuthorTextBox.Text);
                    cmd.Parameters.AddWithValue("bookCategoryDropDown", bookCategoryDropDown.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("bookCountTextBox", bookCountTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book data saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
