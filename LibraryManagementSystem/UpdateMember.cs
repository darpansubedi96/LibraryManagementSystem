using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LMS
{
    public partial class UpdateMember : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        public int id;
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand comm = new SqlCommand("Select * From Member where id =" + id, cn);

            SqlDataReader DR1 = comm.ExecuteReader();
            if (DR1.Read())
            {
                string id = DR1.GetValue(0).ToString();
                textBox1.Text = DR1.GetValue(1).ToString();
                textBox2.Text = DR1.GetValue(2).ToString();
                comboBox1.Text = DR1.GetValue(3).ToString();
                textBox3.Text = DR1.GetValue(4).ToString();
            }
            cn.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty ||
               comboBox1.Text != string.Empty || textBox3.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from Member where name = '" + textBox1.Text + "' and address = '" + textBox2.Text + "'  and gender = '" + comboBox1.Text + "' and phone = '" + textBox3.Text+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())  // validate from table
                {
                    dr.Close();
                    MessageBox.Show("Member already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Member SET name = @memberName, address = @memberAddress, gender = @memberGender, phone = @memberPhone WHERE id = " + id, cn);
                    cmd.Parameters.AddWithValue("memberName", textBox1.Text);
                    cmd.Parameters.AddWithValue("memberAddress", textBox2.Text);
                    cmd.Parameters.AddWithValue("memberGender", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("memberPhone", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member data updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d+"))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Phone number must be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }
    }
}
