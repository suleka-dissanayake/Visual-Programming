using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace form7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = t1.Text;
            int age = Convert.ToInt32(t2.Text);

            // Gender
            string gender = "";
            if (r1.Checked) gender = "Male";
            else if (r2.Checked) gender = "Female";
            else if (r3.Checked) gender = "Other";
            else gender = "Not Selected";

            // Hobbies
            StringBuilder hobbies = new StringBuilder();
            if (c1.Checked) hobbies.Append("Sports ");
            if (c2.Checked) hobbies.Append("Music ");
            if (c3.Checked) hobbies.Append("Reading ");

            // Course
            string course = co1.SelectedItem != null ? co1.SelectedItem.ToString() : "Not Selected";

            // Display details
            string details = $"--- Student Details ---\n\n" +
                             $"Name: {name}\n" +
                             $"Age: {age}\n" +
                             $"Gender: {gender}\n" +
                             $"Hobbies: {hobbies}\n" +
                             $"Course: {course}";

            MessageBox.Show(details, "Registration Successful");
        }
    }
}

