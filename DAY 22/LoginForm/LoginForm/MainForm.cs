using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainForm : Form
    {
        string _username;
        public MainForm(string username = "")
        {
            InitializeComponent();
            _username = username;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            l1.Text = $"Welcome, {_username}!";
        }

        private void l1_Click(object sender, EventArgs e)
        {

        }
    }
}
