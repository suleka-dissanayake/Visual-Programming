using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            try
            {
                DateTime dob = DateTime.Parse(textBox1.Text); //Read dob from textbox

                int age = DateTime.Now.Year - dob.Year; // Calculate age

                if (DateTime.Now.DayOfYear < dob.DayOfYear)//Adjust if bdy hasn't occurred yet this year
                {
                    age--;
                    label2.Text = "Your Age: " + age.ToString() + " years"; //Display age
                }
                else
                {
                    label2.Text = "Your Age: " + age.ToString() + " years";
                }
            }
            catch
            {

            }
        }
    }
}
