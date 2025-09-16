using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder selectedOptions = new StringBuilder("You selected: \n\n");

            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedOptions.AppendLine(checkBox.Text);
                }
            }

            label1.Text = selectedOptions.ToString();
        }

    }
}
