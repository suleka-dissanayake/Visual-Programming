using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String un = textBox1.Text;
            String pw = textBox2.Text;

            if (un == "admin" && pw == "123")
            {
                label3.Visible = true;
                label3.Text = "Login Successfull!";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Invalid username or password!";
                label3.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
