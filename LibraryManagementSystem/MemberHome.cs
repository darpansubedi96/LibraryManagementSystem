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
    public partial class MemberHome : Form
    {
        SqlConnection conn;
        SqlDataReader rdr;
        SqlCommand cmd;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public string username;
        public MemberHome()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLogin studentLogin = new MemberLogin();
            studentLogin.Show();
        }

        private void MemberHome_Load(object sender, EventArgs e)
        {
            string bookName = null;

            conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select bookName from Lend where borrowerName = (select name from Member where username='"+username+"')";
            cmd = new SqlCommand(q, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                bookName = rdr[0].ToString();
            }
            label1.Text = bookName;
        }
    }
}
