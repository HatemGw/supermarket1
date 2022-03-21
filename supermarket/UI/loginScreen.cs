using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace supermarket.UI
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "admin" && textpassword.Text == "1234")
            {
                frmAdminDashboard admin = new frmAdminDashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                textUsername.Clear();
                textpassword.Clear();
                textUsername.Focus();

            }
        }
        private void loginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textpassword.Clear();
            textUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
