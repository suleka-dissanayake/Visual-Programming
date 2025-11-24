using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;//To use Regex
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Name cannot be empty!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^[A-Za-z\s]+$"))
            {
                errorProvider1.SetError(textBox1, "Name must contain only letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void age_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(textBox2.Text, out int age) || age <= 0)
            {
                errorProvider1.SetError(textBox2, "Enter a valid positive number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = $"Name : {textBox1.Text} \nAge: {textBox2.Text}";
        }

        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                //e.SuppressKeyPress = true;
            }
        }
    }
}
