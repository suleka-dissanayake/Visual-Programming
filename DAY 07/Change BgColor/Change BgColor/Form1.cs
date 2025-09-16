using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_BgColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
