using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            Student S = new Student(textBox1.Text, int.Parse(textBox2.Text));
            label3.Text = $"{S.Name}'s Grade: {S.GetGrade()}";
        }
    }
}
