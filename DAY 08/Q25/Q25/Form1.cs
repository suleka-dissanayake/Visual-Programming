using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q25
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
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select an item first!", "No item selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
