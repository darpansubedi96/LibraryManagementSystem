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
            //add count to Books table
            string borrowername = borrowerNameComboBox.SelectedItem.ToString();
            string bookName = label8.Text;
            string count = label9.Text;

            string query = "Update Books set count = count +" + count + " where id IN (select b.id from Books b inner join Lend l on b.name = l.bookName where l.bookName = '" + bookName + "')";
            cmd = new SqlCommand(query,cn);
            cmd.ExecuteNonQuery();

            // delete from Lend table
            string query1 = "Delete from Lend where borrowerName= '"+borrowername+"' and bookName= '"+bookName+"' and noOfBooks= '"+count+"'";
            cmd = new SqlCommand(@query1,cn);
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
            string query = "Select borrowerName from Lend";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                borrowerNameComboBox.Items.Add(rdr[0].ToString());
            }
            rdr.Close();

        }
        
        private void bookOperation()
        {
            string borrowerName = borrowerNameComboBox.SelectedItem.ToString();
            string booksName = null;
            string booksCount = null;
            string borrowedDate = null;
            //string id = null;
            string query = "select bookname, noOfBooks, fromDate from Lend where borrowerName='"+borrowerName+"'";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //id = rdr[0].ToString();
                booksName =rdr[0].ToString();
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
            if (days<=7)
            {
                this.label11.Text = "￥0";
            }
            else if(days>7&&days<15)
            {
                this.label11.Text = "￥200";
            }
            else if(days > 15 && days < 30)
            {
                this.label11.Text = "￥500";
            }
            else
            {
                this.label11.Text = "￥1000";
            }
            bookOperation();
        }
    }
}
