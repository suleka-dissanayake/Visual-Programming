using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();

            if (task != "")
            {
                comboBox1.Items.Add(task);
                textBox1.Clear();
                textBox1.Focus(); //Keep the cursor in textbox
            }
            else
            {
                MessageBox.Show("Enter a task before adding!", "Warning!");
            }
        }
    }
}
