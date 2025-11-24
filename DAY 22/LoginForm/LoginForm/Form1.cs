using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            t2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = t1.Text;
            string password = t2.Text;

          
            string connectionString = "server=127.0.0.1;user=root;database=users;password=;";

            MySqlConnection con = new MySqlConnection(connectionString);
            
                try
                {
                    con.Open();

                    string query = "SELECT * FROM user WHERE Username=@username AND Password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm(username);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
      

        private void register_Click(object sender, EventArgs e)
        {
          
            Register r=new Register();
            r.Show();
            this.Hide();
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void c1_CheckedChanged_1(object sender, EventArgs e)
        {
            t2.UseSystemPasswordChar = !c1.Checked;

        }
    }
}
