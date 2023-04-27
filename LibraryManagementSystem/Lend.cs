using LibraryManagementSystem;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LMS
{
    public partial class Lend : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        General general = new General();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public Lend()
        {
            InitializeComponent();
        }

        private void lendButton_Click(object sender, EventArgs e)
        {

            if (borrowerNameComboBox.SelectedIndex == -1 && bookNameComboBox.SelectedIndex == -1 && noOfBooksTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string requiredBookName = bookNameComboBox.SelectedItem.ToString();
                string requiredNoOfBooks = noOfBooksTextBox.Text;
                int requiredNoOfBooksInt = Convert.ToInt32(requiredNoOfBooks);
                int availableNoOfBooks = 0;
                cn = new SqlConnection(connectionString);
                cn.Open();
                cmd = new SqlCommand("SELECT count FROM Books b WHERE b.name ='" + requiredBookName + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    availableNoOfBooks = Convert.ToInt32(dr.GetValue(0).ToString()); //number of books available in library
                }
                dr.Close();
                if (availableNoOfBooks > 0 && requiredNoOfBooksInt > 0)
                {
                    if (availableNoOfBooks >= requiredNoOfBooksInt)
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
                        string borrowerName = borrowerNameComboBox.SelectedItem.ToString();
                        string fromDate1 = borrowDateTimePicker.Text;
                        cmd = new SqlCommand("INSERT INTO Lend (borrowerName, bookName, fromDate, noOfBooks) VALUES('" + borrowerName + "', '" + requiredBookName + "', '" + fromDate1 + "', '" + requiredNoOfBooks + "');", cn);

                        cmd.ExecuteNonQuery();
                        countOperation(requiredBookName, availableNoOfBooks, requiredNoOfBooksInt);
                        MessageBox.Show("Book borrowed successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        general.ClearAll(this);
                        dataGridViewBorrower.Rows.Clear();
                        dataGridViewBorrower.Refresh();
                        loadLendData();
                    }
                    else
                    {
                        MessageBox.Show("Required number is greter than available", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Book not available.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void countOperation(string bookName, int bookCount, int noOfBooks)
        {
            //bookName - name of book
            //bookCount - total books available in library
            //noOfBooks.Text - users want to borrow

            int newBookNumber = bookCount - noOfBooks;

            cn = new SqlConnection(connectionString);
            cn.Open();
            cmd = new SqlCommand("UPDATE Books SET count =" + newBookNumber + " WHERE name ='" + bookName + "';", cn);//update operation
            cmd.ExecuteNonQuery();
        }

        private void Lend_Load(object sender, EventArgs e)
        {
            loadLendData();
            BindMemberName();
            BindData();
        }

        private void loadLendData()
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand comm = new SqlCommand("Select * From Lend b", cn);
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridViewBorrower.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4)
                    });
                }
            }
        }

        public void BindData()
        {
            cmd = new SqlCommand("Select name From Books b ORDER BY b.name", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bookNameComboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        public void BindMemberName()
        {
            cmd = new SqlCommand("Select name from Member m ORDER BY m.name", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                borrowerNameComboBox.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noOfBooksTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(noOfBooksTextBox.Text, @"^\d+"))
            {
                e.Cancel = true;
                noOfBooksTextBox.Focus();
                errorProvider1.SetError(noOfBooksTextBox, "Number of books must be a number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(noOfBooksTextBox, "");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            general.logout(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
