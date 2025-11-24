using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            if (email.Contains("@"))
            {
                label2.Text = "Valid email!";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Invalid email!";
                label2.ForeColor = Color.Red;
            }
        }
    }
}
