using LibraryManagementSystem;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LMS
{
    public partial class Membership : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        MemoryStream ms;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";

        General general = new General();

        public Membership()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty || addressTextBox.Text != string.Empty || 
                genderComboBox.SelectedIndex == -1 || !string.IsNullOrWhiteSpace(PhoneNoTextBox.Text))
            {
                cmd = new SqlCommand("select * from Member where name = '" + nameTextBox.Text + "' and address = '" + addressTextBox.Text + "' and gender = '" + genderComboBox.Text + "' and phone = '"+PhoneNoTextBox.Text+"'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())  // validate from table
                {
                    rdr.Close();
                    MessageBox.Show("Member already exists in Library.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            rdr.Close();
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                    rdr.Close();

                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO Member (name, address, gender, phone, image, dateOfJoin) VALUES(@memberName, @memberAddress, @memberGender, @memberPhoneNumber, @image, @dateOfJoin);", conn);

                    conv_photo();

                    currentdate();

                    cmd.Parameters.AddWithValue("memberName", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("memberAddress", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("memberGender", genderComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("memberPhoneNumber", PhoneNoTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member data saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    Membership main = new Membership();
                    main.Show();
                    
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void currentdate()
        {
            var dateTime = DateTime.Now;
            var longDateTime = dateTime.ToLongDateString();
            cmd.Parameters.AddWithValue("@dateOfJoin", longDateTime);
        }
        void conv_photo()
        {
            //converting photo to binary data
            if (pictureBox1.Image != null)
            {
                //using FileStream:(will not work while updating, if image is not changed)
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                //byte[] photo_aray = new byte[fs.Length];
                //fs.Read(photo_aray, 0, photo_aray.Length);  

                //using MemoryStream:
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@image", photo_aray);
            }
        }

        private void cancleBotton_Click(object sender, EventArgs e)
        {
            general.ClearAll(this);
        }
        
        

        private void Membership_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("Select * From Member m order by name", conn);
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(1),
                        read.GetValue(2),
                        read.GetValue(3),
                        read.GetValue(4)
                    });
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = this.dataGridView1.Columns[e.ColumnIndex].Name;
            conn = new SqlConnection(connectionString);
            conn.Open();
            int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (id > 0)
            {
                if (columnName.Equals("delete"))
                {
                    SqlCommand comm = new SqlCommand("Delete From Member WHERE id =" + id, conn);

                    if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            comm.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
                else if (columnName.Equals("edit"))
                {
                    UpdateMember update = new UpdateMember() { id = id };
                    update.ShowDialog();
                }
                else
                {
                    MemebershipCard memebershipCard = new MemebershipCard() { id = id };
                    memebershipCard.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You can't delete or update this field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PhoneNoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(PhoneNoTextBox.Text, @"^\d+"))
            {
                e.Cancel = true;
                PhoneNoTextBox.Focus();
                errorProvider1.SetError(PhoneNoTextBox, "Phone number must be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PhoneNoTextBox, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Membership membership = new Membership();
            membership.Show();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            general.logout(this);
        }
    }
}
