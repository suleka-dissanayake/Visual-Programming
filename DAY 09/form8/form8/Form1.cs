using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(t1.Text))
            {
                if (double.TryParse(t1.Text, out double temp))
                {
                    li1.Items.Add(temp);
                    t1.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number!", "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (li1.Items.Count > 0)
            {
                double sum = 0;
                foreach (var item in li1.Items)
                {
                    sum += Convert.ToDouble(item);
                }
                double avg = sum / li1.Items.Count;
                l1.Text = avg.ToString("F2");
            }
            else
            {
                l1.Text = "Error";
            }
        }
    }
}
