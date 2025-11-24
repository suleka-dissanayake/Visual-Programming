using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q7
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
            //label2.Visible = false;
            if(int.TryParse(textBox1.Text, out int value))
            {
                if(value % 2 == 0)
                {
                    label2.Visible = true;
                    label2.Text = "This is an Even Number!";
                    label1.Visible = false;
                    button1.Visible = false;
                }
                else if(value % 2 == 1)
                {
                    label2.Visible = true;
                    label2.Text = "This is an Odd Number!";
                    label1.Visible = false;
                    button1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            label1.Visible = true;
            button1.Visible = true;

        }
    }
}
