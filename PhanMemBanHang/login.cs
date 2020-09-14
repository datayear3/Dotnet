using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBanHang
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            user.Clear();
            panel1.BackColor = Color.FromArgb(255, 89, 172);
            panel2.BackColor = Color.FromArgb(255, 248, 227);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            passwd.Clear();
            passwd.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(255, 89, 172);
            panel1.BackColor = Color.FromArgb(255, 248, 227);
        }
    }
}
