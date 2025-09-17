using System;
using System.Windows.Forms;

namespace EEMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string password = txtPassword.Text;

            // Simple hardcoded login check
            if (userId == "admin" && password == "123")
            {
                // Hide login form
                this.Hide();

                // Show Form2 (dashboard)
                Form2 dashboard = new Form2();
                dashboard.FormClosed += (s, args) => this.Close(); // Close login form when Form2 closes
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
