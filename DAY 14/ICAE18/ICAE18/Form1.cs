using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICAE18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("Pure Mathematics");
                listBox1.Items.Add("Combined Mathematics");
                listBox1.Items.Add("Physics");
                listBox1.Items.Add("ICT");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Tamil Language");
                listBox1.Items.Add("English Language");
                listBox1.Items.Add("Logics");
                listBox1.Items.Add("Art");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("Agriculture");
                listBox1.Items.Add("Chemistry");
                listBox1.Items.Add("Zoology");
                listBox1.Items.Add("Botony");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add("Robotics");
                listBox1.Items.Add("Electronics");
                listBox1.Items.Add("Mechanics");
                listBox1.Items.Add("AI");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                listBox1.Items.Add("Political Science");
                listBox1.Items.Add("Bussiness Studies");
                listBox1.Items.Add("Accounts");
                listBox1.Items.Add("Economics");
            }
            else
            {
                MessageBox.Show("Select a stream from the given list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "*****************Personal Details*****************\n"
                + $"Name: {textBox2.Text}\n"
                + $"Registration Number: {textBox1.Text}\n";

            if(radioButton1.Checked) { richTextBox2.Text += "Sex: Male"; }
            else if(radioButton2.Checked){ richTextBox2.Text += "Sex: Female"; }

            richTextBox2.Text += "\n\n************Language Ability in English************\n";

            if (checkBox1.Checked) { richTextBox2.Text += "Read : Can Read\n"; }
            else { richTextBox2.Text += "Read : Can't Read\n"; }

            if (checkBox2.Checked) { richTextBox2.Text += "Write : Can Write\n"; }
            else { richTextBox2.Text += "Write : Can't Write\n"; }

            if (checkBox3.Checked) { richTextBox2.Text += "Speak : Can Speak\n"; }
            else { richTextBox2.Text += "Speak : Can't Speak\n"; }

            richTextBox2.Text += "\n****************Educational Details****************\n"
                + $"Stream : {comboBox1.SelectedItem}"
                + "\nSubjects followed: ";

            foreach (var item in listBox2.Items)
            {
                richTextBox2.Text += $"\n{item}";
            }
        }
    }
}
