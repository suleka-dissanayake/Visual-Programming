using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q26
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
            string order = "Your orders:";
            int total = 0;
            label2.Visible = true;

            if (checkBox1.Checked)
            {
                order += " Pizza";
                total += 10;
            }
            if (checkBox2.Checked)
            {
                order += " Burger";
                total += 5;
            }
            if (checkBox3.Checked)
            {
                order += " Coke";
                total += 3;
            }
            order = order + "\n Total = " + total;
            label2.Text = order;
        }
    }
}
