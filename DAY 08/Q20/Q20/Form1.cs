using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q20
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            //Initialize Timer
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Completed!","Progress",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
