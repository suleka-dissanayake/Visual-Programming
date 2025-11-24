using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "Admin1" && textBox2.Text.Trim() == "Admin@123")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else{
                label4.Visible = true;
                label4.Text = "Invalid Username or Password!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
