﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Registration()
        {
            InitializeComponent();
        }

        private void RegisterNowButton_Click(object sender, EventArgs e)
        {
            if (regConfirmPasswordtextBox.Text != string.Empty && regPasswordTextBox.Text != string.Empty && regUsernameTextBox.Text != string.Empty)
            {
                if (regPasswordTextBox.Text == regConfirmPasswordtextBox.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + regUsernameTextBox.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", regUsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("password", regPasswordTextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.ShowDialog();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True");
            cn.Open();
        }

    }
}
