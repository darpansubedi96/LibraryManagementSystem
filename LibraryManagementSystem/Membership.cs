﻿using LibraryManagementSystem;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LMS
{
    public partial class Membership : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";

        General general;

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
                    cmd = new SqlCommand("INSERT INTO Member (name, address, gender, phone) VALUES(@memberName, @memberAddress, @memberGender, @memberPhoneNumber);", conn);
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

        private void cancleBotton_Click(object sender, EventArgs e)
        {
            ClearAll(this);
        }
        
        public static void ClearAll(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var texbox = c as TextBox;
                var comboBox = c as ComboBox;
                var dateTimePicker = c as DateTimePicker;

                if (texbox != null)
                    texbox.Clear();
                if (comboBox != null)
                    comboBox.SelectedIndex = -1;
                /*if (dateTimePicker != null)
                {
                    dateTimePicker.Format = DateTimePickerFormat.Short;
                    dateTimePicker.CustomFormat = " ";
                }*/
                if (c.HasChildren)
                    ClearAll(c);
            }
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
                else
                {
                    UpdateMember update = new UpdateMember() { id = id };
                    update.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You can't delete or update this field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            general.logout(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
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
    }
}
