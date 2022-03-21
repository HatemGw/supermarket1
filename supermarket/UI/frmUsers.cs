using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace supermarket.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        public static implicit operator ToolStripMenuItem(frmUsers v)
        {
            throw new NotImplementedException();
        }

        private void users_label_Click(object sender, EventArgs e)
        {

        }

        private void close_box_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
