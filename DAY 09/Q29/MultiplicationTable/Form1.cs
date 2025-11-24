using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBox1.Text, out int n))
            {
                listBox1.Visible = true;
                for (int i = 1; i <= 12; i++)
                {
                    listBox1.Items.Add($"{n} x {i} = {n * i}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            
        }
    }
}
