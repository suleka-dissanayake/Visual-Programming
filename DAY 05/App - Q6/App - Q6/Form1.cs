using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox1.Text) > 40)
            {
                label2.Text = "Pass";
            }
            else
            {
                label2.Text = "Fail";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
