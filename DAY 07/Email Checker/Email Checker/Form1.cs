using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = textBox1.Text;

            if (email.Contains("@") && email.Contains("."))
            {
                label2.Text = "Valid Email";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Invalid email";
                label2.ForeColor= Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
