using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int marks))
            {
                if(marks >= 40)
                {
                    textBox2.Text = "Pass";
                    textBox2.ForeColor = Color.Green;
                }
                else
                {
                    textBox2.Text = "Fail";
                    textBox2.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "";
        }
    }
}
