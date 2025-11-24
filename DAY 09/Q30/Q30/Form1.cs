using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q30
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
            Random random = new Random();
            int guess = random.Next(1, 101);


            if (int.TryParse(textBox1.Text, out int value))
            {
                if(value > 0 && value <= 100)
                {
                    label2.Visible = true;
                    if (value > guess)
                    {
                        label2.Text = "Too High, Try Again! The Number is " + guess.ToString();
                    }
                    else if (value < guess)
                    {
                        label2.Text = "Too Low, Try Again! The Number is " + guess.ToString();
                    }
                    else
                    {
                        label2.Text = "Correct Guess! The Number is " + guess.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 to 100!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Guess a new number!";
        }
    }
}
