using System;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        int secretNum;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate the secret number once when the form loads
            secretNum = rnd.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Try to parse the user's guess
            if (int.TryParse(textBox1.Text, out int guess))
            {
                if (guess < secretNum)
                {
                    label1.Text = "Too low!";
                }
                else if (guess > secretNum)
                {
                    label1.Text = "Too high!";
                }
                else
                {
                    label1.Text = "Correct!";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 and 100.");
            }

            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: You can add input validation here if needed
        }
    }
}