using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator
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
            label2.Visible = true;

            try
            {
                DateTime dob = DateTime.Parse(textBox1.Text);
                int age = DateTime.Now.Year - dob.Year;

                if (DateTime.Now.DayOfYear < dob.DayOfYear)
                    age--;

            label2.Text = $"Your age: {age.ToString()} years";
            }
            catch
            {
                label2.Text = "Invalid!";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
        }
    }
}
