using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            String selected = "";

            if (radioButton1.Checked) selected = radioButton1.Text;
            else if (radioButton2.Checked) selected = radioButton2.Text;
            else if (radioButton3.Checked) selected = radioButton3.Text;
            else if (radioButton4.Checked) selected = radioButton4.Text;
            else if (radioButton5.Checked) selected = radioButton5.Text;

            if (selected == "")
            {
                MessageBox.Show("Please select an answer!");
            }
            else
            {
                // You can customize this part to show feedback or evaluate the answer
                label1.Text = "You selected: " + selected;

                // Example: check if the selected answer is correct
                string correctAnswer = "Option 3"; // Replace with your actual correct answer text
                if (selected == correctAnswer)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Incorrect. Try again!");
                }
            }
        }
    }
}
