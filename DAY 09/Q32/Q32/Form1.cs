using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q32
{
    public partial class Form1 : Form
    {
        int elapsedSeconds = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "00:00:00";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            TimeSpan ts = TimeSpan.FromSeconds(elapsedSeconds);
            label1.Text = ts.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            elapsedSeconds = 0;
            label1.Text = "00:00:00";
        }
    }
}
