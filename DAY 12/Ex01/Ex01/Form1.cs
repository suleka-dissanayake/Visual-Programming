using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb(object sender, EventArgs e)
        {
        
            l1.Items.Clear();
            l2.Items.Clear();

            switch (cmp1.SelectedIndex)
            {
                case 0:
                    l1.Items.Add("Algebra");
                    l1.Items.Add("Calculus");
                    l1.Items.Add("Statistics");
                    l1.Items.Add("Geometry");
                    break;

                case 1:
                    l1.Items.Add("History");
                    l1.Items.Add("Geography");
                    l1.Items.Add("Political Science");
                    l1.Items.Add("Sociology");
                    break;

                case 2:
                    l1.Items.Add("Biology");
                    l1.Items.Add("Chemistry");
                    l1.Items.Add("Genetics");
                    l1.Items.Add("Microbiology");
                    break;

                case 3:
                    l1.Items.Add("Computer Science");
                    l1.Items.Add("Electronics");
                    l1.Items.Add("Information Technology");
                    l1.Items.Add("Robotics");
                    break;

                case 4:
                    l1.Items.Add("Accounting");
                    l1.Items.Add("Economics");
                    l1.Items.Add("Business Studies");
                    l1.Items.Add("Finance");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string regNo = t1.Text;
            string name = t2.Text;
            string Addi = t3.Text;
            string sex1 = r2.Checked ? "Male" : "Female";
            //string sex2 = r2.Checked ? "FeMale" : "Male";


            string read = c1.Checked ? "Can Read" : "Can't Read";
            string write = c2.Checked ? "Can Write" : "Can't Write";
            string speak = c3.Checked ? "Can Speak" : "Can't Speak";


            string subjects = "";
            foreach (var item in l2.Items)
            {
                subjects += item.ToString() + "\n";
            }

            lis.Text = "**********Personal Details**********"+"\n\n"+"Name: " + name + "\n" +
                             "Registration Number: " + regNo + "\n" +
                             "Sex: " + sex1 + "\n" +
                             "Address: " + Addi + "\n\n" +
                             "*****Language ability in English:*****\n\n" +
                             "Read: " + read + "\n" +
                             "Write: " + write + "\n" +
                             "Speak: " + speak + "\n\n" +
                             "*****Educational Details:*****\n\n" +
                             "Stream: " + cmp1.SelectedItem + "\n" +
                             "Subjects followed:\n" + subjects;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(l1.SelectedItem!=null)
            {
                l2.Items.Add(l1.SelectedItem);
                l1.Items.Remove(l1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in l1.Items)
            {
                l2.Items.Add(item);
            }
            l1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (l2.SelectedItem != null)
            {
                l1.Items.Add(l2.SelectedItem);
                l2.Items.Remove(l2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in l2.Items)
            {
                l1.Items.Add(item);
            }
            l2.Items.Clear();
        }
    }
}
