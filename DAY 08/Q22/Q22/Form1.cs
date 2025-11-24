using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q22
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
            //Change bg clr randomly when mouse moves
            Random rdm = new Random();
            this.BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256)); 
        }
    }
}
