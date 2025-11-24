using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Box_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            String lang = "";

            if (checkBox1.Checked)
            {
                lang += "C# ";
            }
            if (checkBox2.Checked)
            {
                lang += "Java ";
            }
            if (checkBox3.Checked)
            {
                lang += "Python ";
            }

            if(lang == "")
            {
                label2.Text = "None Selected!";
            }
            else
            {
                label2.Text = "Selected Languages: " + lang;
            }
        }
    }
}
