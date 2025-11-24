using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonfn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            richTextBox1.Text += btn.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string answer = richTextBox1.Text;
            answer = answer.Replace("÷", "/");
            answer = answer.Replace("x", "*");
            var results = new DataTable().Compute(answer, null);
            richTextBox1.Text = results.ToString();
        }


        private void clearfn(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                double value = Convert.ToDouble(richTextBox1.Text);
                double results = Math.Pow(value, 2);
                richTextBox1.Text = results.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                double value = Convert.ToDouble(richTextBox1.Text);
                double results = 1/value;
                richTextBox1.Text = results.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                double value = Convert.ToDouble(richTextBox1.Text);
                double results = Math.Sqrt(value);
                richTextBox1.Text = results.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(richTextBox1.Text);
            value = -value;
            richTextBox1.Text = value.ToString();
        }
    }
}
