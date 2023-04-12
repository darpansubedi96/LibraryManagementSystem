using LMS;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        General general = new General();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
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
            general.logout(this);
        }

        private void saveBook_Click(object sender, EventArgs e)
        {

            if (booksNameTextbox.Text == string.Empty || booksAuthorTextBox.Text == string.Empty ||
                bookCountTextBox.Text == string.Empty || bookCategoryDropDown.SelectedIndex == -1)
                {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show(bookCountTextBox.Text, "Demo App - Message!");
                }
                else {
                    cmd = new SqlCommand("select * from Books where name = '" + booksNameTextbox.Text + "' and author = '" + booksAuthorTextBox.Text + "'  and category = '" + bookCategoryDropDown.Text + "'", cn);
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
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        private void bookCountTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(bookCountTextBox.Text, @"^\d+"))
            {
                e.Cancel = true;
                bookCountTextBox.Focus();
                errorProvider1.SetError(bookCountTextBox, "Count must be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(bookCountTextBox, "");
            }
        }
    }
}
