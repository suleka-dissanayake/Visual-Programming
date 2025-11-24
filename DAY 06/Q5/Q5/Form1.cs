using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim();//Rmvs whitespace

            label2.Visible = true;

            if (String.IsNullOrEmpty(name))
            {
                label2.Text = "Please Enter Your Name!";
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label2.Text = "Hello, "+ name + "!";
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }
        }
    }
}
