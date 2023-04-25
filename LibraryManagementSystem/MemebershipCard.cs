using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMS
{
    public partial class MemebershipCard : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darpan\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database.mdf;Integrated Security=True";
        byte[] photo_aray;

        public int id;
        public MemebershipCard()
        {
            InitializeComponent();
        }

        private void MemebershipCard_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            cmd = new SqlCommand("Select * From Member where id =" + id, cn);

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string id = rdr.GetValue(0).ToString();
                nameLabel.Text = rdr.GetValue(1).ToString();
                addressLabel.Text = rdr.GetValue(2).ToString();
                genderlabel.Text = rdr.GetValue(3).ToString();
                phonelabel.Text = rdr.GetValue(4).ToString();
                dateofjoinLabel.Text = rdr.GetValue(6).ToString();

                pictureBox1.Image = null;
                if (rdr.GetValue(5) != System.DBNull.Value)
                {
                    photo_aray = (byte[])rdr.GetValue(5);
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.ImageLocation = @"C:\Users\darpan\Downloads\no.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            cn.Close();
        }

    }
}
