using LMS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminLogin : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text != string.Empty && usernameTextbox.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + usernameTextbox.Text + "' and password='" + passwordTextbox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    AdminHome home = new AdminHome();
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
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
