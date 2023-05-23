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
    public partial class MemberLogin : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";

        public MemberLogin()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                string username = usernameTextBox.Text;
                cmd = new SqlCommand("select * from Member where username='" + username + "' and password='" + passwordTextBox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MemberHome home = new MemberHome() { username = username };
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "AccountNotAvailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MemberLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
        }
    }
}
