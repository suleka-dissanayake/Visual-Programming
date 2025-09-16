using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\2022ict81.TECH0\Desktop\2022ICT81\IT 2143\DAY 06\Image Viewer\images.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\2022ict81.TECH0\Desktop\2022ICT81\IT 2143\DAY 06\Image Viewer\download.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\2022ict81.TECH0\Desktop\2022ICT81\IT 2143\DAY 06\Image Viewer\download (1).jpg";
        }
    }
}
