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
            //calculate fine
            // add count to Books table
            // delete from Lend table
        }
        private int fineCalculation()
        {
            return 0;  //this is to calculate fine
        }

        private void Return_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            borrowerName();
            // load the borrower name
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
            string booksName = null;
            string booksCount = null;
            string borrowedDate = null;
            string query = "select bookname, noOfBooks, fromDate from Lend";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
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
