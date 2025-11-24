using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtn1
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
            if (radioButton1.Checked)
            {
                label2.Text = "Male";
                radioButton2.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "Female";
                radioButton1.Enabled = false;
            }
            else
            {
                label2.Text = "No option selected!";
            }
        }
    }
}
