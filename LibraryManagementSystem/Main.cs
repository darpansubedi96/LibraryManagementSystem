using LibraryManagementSystem;
using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLogin login = new MemberLogin();
            login.ShowDialog();
        }
    }
}
