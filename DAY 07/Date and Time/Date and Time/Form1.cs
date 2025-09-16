using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_and_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            DateTime now = DateTime.Now;

            label1.Text = now.ToString("yyyy MM dd HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
