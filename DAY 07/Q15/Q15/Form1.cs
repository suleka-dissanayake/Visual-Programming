using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q15
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
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32.0;
                label2.Text = $"{fahrenheit:F2} F";
            }
            //label2.Text = Convert.ToString((Convert.ToDouble(textBox1.Text)*9/5)+32.0);
            else
            {
                MessageBox.Show("Enter valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
        }
    }
}
