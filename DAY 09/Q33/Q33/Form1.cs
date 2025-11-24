using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string book = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(book);
                listBox2.Items.Add(book);
            }
            else
            {
                MessageBox.Show("Please select a book!", "Available Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string book = listBox2.SelectedItem.ToString();
                listBox2.Items.Remove(book);
                listBox1.Items.Add(book);
            }
            else
            {
                MessageBox.Show("Please select a book!", "Borrowed Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
