using System;
using System.Windows.Forms;

namespace Multiplication_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();

            /*if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } */

            if (!int.TryParse(textBox2.Text, out int num))
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            for (int i = 1; i <= 12; i++)
            {
                int result = num * i;
                richTextBox2.AppendText($"{num} × {i} = {result}\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}