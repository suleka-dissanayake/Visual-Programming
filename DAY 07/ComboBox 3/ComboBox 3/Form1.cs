using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Matale");
            comboBox1.Items.Add("Mannar");
            comboBox1.Items.Add("Galle");
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            if(comboBox1.SelectedItem !=null)
            {
                label2.Text = "Your choice: " + comboBox1.SelectedItem.ToString();
            }
            else
            {
                label2.Text = "None Selected!";
            }
        }
    }
}
