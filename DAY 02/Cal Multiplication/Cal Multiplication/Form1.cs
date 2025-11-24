using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal_Multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double value1 = Convert.ToDouble(textBox1.Text);
            Double value2 = Convert.ToDouble(textBox2.Text);
            Double mul = value1 * value2;
            textBox3.Text = mul.ToString();
        }
    }
}
