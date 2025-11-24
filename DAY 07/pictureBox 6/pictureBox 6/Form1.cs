using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\2022ICT68\Pictures.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }
    }
}
