using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Details_Management_System
{
    public partial class Form2 : Form
    {
        public string details;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameValidating(object sender, CancelEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieIdValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "ID cannot be empty!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[A-Za-z\s]+$"))
            {
                errorProvider1.SetError(textBox2, "ID format should be like 4-digits/4-characters-1 to 3-digits (Eg: 1998/KHJL-21).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void reviewValidating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int review) && review <= 9)
            {
                errorProvider1.SetError(textBox3, "Enter a valid number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void directorValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Name cannot be empty!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[A-Za-z\s]+$"))
            {
                errorProvider1.SetError(textBox4, "Name must contain only letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void emailValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Email ID cannot be empty!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox5.Text, @"^[a]+$") && !Regex.IsMatch(textBox5.Text, @"^[c]+$"))
            {
                errorProvider1.SetError(textBox5, "Email ID must contain '@' ");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void companyValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "Name cannot be empty!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(textBox6.Text, @"^[A-Za-z\s]+$"))
            {
                errorProvider1.SetError(textBox6, "Name must contain only letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movieName = textBox1.Text;
            string movieId = textBox2.Text;
            string director = textBox4.Text;
            string emailId = textBox5.Text; 
            string productionCompany = textBox6.Text;
            int review = Convert.ToInt32(textBox3.Text);

            MovieClass mc = new MovieClass(movieName, movieId, director, emailId, productionCompany, review);
            details = mc.displayDetails(); 
            MessageBox.Show("Successfully added!");
            this.Close();
        }
    }
}
