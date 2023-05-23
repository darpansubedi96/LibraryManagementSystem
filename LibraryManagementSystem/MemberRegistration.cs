using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class MemberRegistration : Form
    {
        SqlConnection cn;
        SqlDataReader rdr;
        SqlCommand cmd;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public MemberRegistration()
        {
            InitializeComponent();
        }

        private void MemberRegistration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            cmd = new SqlCommand("Select name From Member m ORDER BY m.name", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                memberComboBox.Items.Add(rdr[0].ToString());
            }
            rdr.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (memberUserName.Text != null && memberPassword.Text != null)
            {

                string user = memberComboBox.SelectedItem.ToString();
                string username = memberUserName.Text;
                string password = memberPassword.Text;
                //check if the username match or not
                string q = "select * from Member where username ='"+username+"'";
                cmd = new SqlCommand(q, cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Account with following username is already exists, Please enter another username","AccountExists",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    rdr.Close();
                }
                else
                {   
                    rdr.Close();
                    string query = "UPDATE Member SET username = '" + username + "', password = '" + password + "' WHERE name = '" + user + "';";
                    cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member account saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void memberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = null, password = null;
            string name = memberComboBox.SelectedItem.ToString();
            string query = "select username, password from Member where name = '"+name+"'";
            cmd = new SqlCommand(query, cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                username = rdr[0].ToString();
                password = rdr[1].ToString();
            }
            rdr.Close();
            this.preUsername.Text = username;
            this.prePassword.Text = password;
        }
    }
}
