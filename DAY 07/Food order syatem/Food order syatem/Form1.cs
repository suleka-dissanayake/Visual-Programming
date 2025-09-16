using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_order_syatem
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String order = "You selected food: ";
            label1.Visible = true;

            if (checkBox1.Checked)
            {
                order += "Pizza ";
                total += 1500;
            }
            if (checkBox2.Checked)
            {
                order += "Burger ";
                total += 750;
            }
            if (checkBox3.Checked)
            {
                order += "Coke ";
                total += 500;
            }

            label1.Text = order + "\nTotal = " + total;
        }
    }
}
