using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Font = new Font(label2.Font.FontFamily, 10, FontStyle.Bold);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.AutoSize = true;
            label2.Font = new Font(label2.Font.FontFamily, 20, FontStyle.Bold);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.AutoSize = true;
            label2.Font = new Font(label2.Font.FontFamily, 30, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
