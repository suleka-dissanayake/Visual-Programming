using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02_IT2143_P_
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double value_1 = Convert.ToDouble(textBox1.Text);
            Double value_2 = Convert.ToDouble(textBox2.Text);
            
            Double sum = label1 + label2;
            textBox3.Text = sum.ToString();
        }
    }
}
