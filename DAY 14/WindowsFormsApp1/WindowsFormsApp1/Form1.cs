using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
                listBox1.Items.Add("Biology");
                listBox1.Items.Add("Chemistry");
                listBox1.Items.Add("Physics");
                listBox1.Items.Add("Mathematics");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Bussiness Studies");
                listBox1.Items.Add("Accounts");
                listBox1.Items.Add("Economics");
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("Tamil Language");
                listBox1.Items.Add("English Language");
                listBox1.Items.Add("Logics");
                listBox1.Items.Add("Art");
                listBox1.Items.Add("Political Science");
            }
            else
            {
                MessageBox.Show("Select a stream from the given list!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }
    }
}
