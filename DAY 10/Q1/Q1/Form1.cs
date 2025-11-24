using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            panel1.Visible = true;

            int red = (int)numericUpDown1.Value;
            int green = (int)numericUpDown2.Value; ;
            int blue = (int)numericUpDown3.Value; ;

            ColorInfo color = new ColorInfo(red, green, blue);
            panel1.BackColor = Color.FromArgb(red, green, blue);
            label4.Text = color.ToString();
        }
    }
}
