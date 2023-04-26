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
    public partial class ResetPassword : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty && repasswordTextBox.Text != String.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + usernameTextBox.Text + "'", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (passwordTextBox.Text.Equals(repasswordTextBox.Text))
                    {
                        rdr.Close();
                        cmd = new SqlCommand("update LoginTable set password = @password where username = @username", cn);
                        cmd.Parameters.AddWithValue("username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password is updated. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password does not match! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rdr.Close();
                    MessageBox.Show("Username does not exist! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
        }
    }
}
