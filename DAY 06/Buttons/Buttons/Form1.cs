using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 10, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 20, FontStyle.Regular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 30, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
