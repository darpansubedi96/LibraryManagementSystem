using LibraryManagementSystem;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LMS
{
    internal class General
    {

        MemoryStream ms;

        public void logout(Control control)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                control.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        public void conv_photo(PictureBox pictureBox1,SqlCommand cmd)
        {
            if (pictureBox1.Image != null)
            {
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@image", photo_aray);
            }
        }

        public void ClearAll(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var texbox = c as TextBox;
                var comboBox = c as ComboBox;
                var dateTimePicker = c as DateTimePicker;
                var pictureBox = c as PictureBox;

                if (texbox != null)
                    texbox.Clear();
                if (comboBox != null)
                    comboBox.SelectedIndex = -1;
                if (c.HasChildren)
                    ClearAll(c);
            }
        }
    }
}
