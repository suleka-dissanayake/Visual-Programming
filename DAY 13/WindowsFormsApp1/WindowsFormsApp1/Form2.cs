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
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = "Hello, " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
