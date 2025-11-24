using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q34
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

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                label2.Text = "Wrong! Correct Answer: Paris";
            }
            else if (radioButton4.Checked)
            {
                label2.Text = " Correct Answer!";
            }
            else
            {
                MessageBox.Show("Select an option!");
            }
        }
    }
}
