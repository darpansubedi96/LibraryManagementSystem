using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class Return : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public Return()
        {
            InitializeComponent();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (borrowerNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select returner name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (label11.Text.Equals("￥0"))
                {
                    returnOperation();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Did you receive the " + label11.Text + " fine?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        returnOperation();
                    }
                }
            }
        }
        private void returnOperation()
        {
            //add count to Books table
            string bookName = label8.Text;
            string count = label9.Text;

            string query = "Update Books set count = count +" + count + " where id IN (select b.id from Books b inner join Lend l on b.name = l.bookName where l.bookName = '" + bookName + "')";
            cmd = new SqlCommand(query, cn);
            cmd.ExecuteNonQuery();


            var splitedtext = borrowerNameComboBox.SelectedItem.ToString().Split('-');
            string a = splitedtext[0].Trim();
            // delete from Lend table
            string query1 = "Delete from Lend where borrowerName= '" + a + "' and bookName= '" + bookName + "' and noOfBooks= '" + count + "'";
            cmd = new SqlCommand(@query1, cn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Book received successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            borrowerName();// load the borrower name
        }

        private void borrowerName()
        {
            string query = "Select borrowerName, bookName from Lend";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string demo = rdr[0] + " - " + rdr[1];
                borrowerNameComboBox.Items.Add(demo);
                //borrowerNameComboBox.Items.Add(rdr[0].ToString());
            }
            rdr.Close();

        }

        private void bookOperation()
        {
            // Initially " - " was added to show better result and now it is removed again.
            var splitedtext = borrowerNameComboBox.SelectedItem.ToString().Split('-');
            string a = splitedtext[0].Trim();

            //string borrowerName = borrowerNameComboBox.SelectedItem.ToString();
            string booksName = null;
            string booksCount = null;
            string borrowedDate = null;
            //string id = null;
            string query = "select bookname, noOfBooks, fromDate from Lend where borrowerName='" + a + "'";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //id = rdr[0].ToString();
                booksName = rdr[0].ToString();
                booksCount = rdr[1].ToString();
                borrowedDate = rdr[2].ToString();
            }
            rdr.Close();
            this.label8.Text = booksName;
            this.label9.Text = booksCount;
            this.label10.Text = borrowedDate;

        }

        private void borrowerNameComboBox_SelectedIndexChanged(object sender, EventArgs e) //this method is executed when we select name from comboBox
        {
            DateTime borrowedDate = DateTime.Now;
            DateTime returnDate = DateTime.Parse(this.returnDateTimePicker.Text);

            string query = "select fromDate from Lend";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                borrowedDate = DateTime.Parse(rdr[0].ToString());
            }
            rdr.Close();


            TimeSpan diffOfDates = returnDate.Subtract(borrowedDate);
            int days = diffOfDates.Days;
            int fineDays, fine;
            if (days <= 7)
            {
                fine = 0;
                this.label11.Text = "￥" + fine;
            }
            else if (days > 7 && days <= 15)
            {
                fineDays = days - 7;
                fine = fineDays * 5;
                this.label11.Text = "￥" + fine;
            }
            else if (days > 15 && days <= 30)
            {
                fineDays = days - 15;
                fine = 40 + fineDays * 10;
                this.label11.Text = "￥" + fine;
            }
            else
            {
                fineDays = days - 30;
                fine = 190 + fineDays * 15;
                if (fine>=5215)
                {
                    fine = 5215;
                }
                this.label11.Text = "￥" + fine;
            }
            bookOperation();
        }

        /*private void returnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (borrowerNameComboBox.SelectedIndex != -1)
            {
                bookOperation();
            }
        }*/
    }
}
