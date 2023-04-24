using LMS;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        General general = new General();
        public Home()
        {
            InitializeComponent();
        }

        private void addBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooks addbooks = new AddBooks();
            addbooks.ShowDialog();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooks viewbooks = new ViewBooks();
            viewbooks.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            general.logout(this);
        }

        private void lendButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lend lend = new Lend();
            lend.ShowDialog();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Return receive = new Return();
            receive.ShowDialog();
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Membership membership = new Membership();
            membership.ShowDialog();
        }

    }
}
