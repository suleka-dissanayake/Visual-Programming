using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Visible = true;
          
            int r = (int)n1.Value;
            int g = (int)n2.Value;
            int b = (int)n3.Value;

            // Create ColorInfo object
            ColorInfo color = new ColorInfo(r, g, b);

            // Update Panel color
            p1.BackColor = Color.FromArgb(r, g, b);

            // Update Label
            l1.Text = color.ToString();
        

    }
}
}
