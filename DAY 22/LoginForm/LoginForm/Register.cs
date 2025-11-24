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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            t2.UseSystemPasswordChar = true;
            t3.UseSystemPasswordChar = true;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            string username = t1.Text.Trim();
            string password = t2.Text;
            string confirmPassword = t3.Text;

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=127.0.0.1;user=root;database=users;password=;";


            MySqlConnection con = new MySqlConnection(connectionString);
            try
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(1) FROM user WHERE Username=@username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                   
                    string insertQuery = "INSERT INTO user (Username, Password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); 

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

      

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            t2.UseSystemPasswordChar = !c1.Checked;

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
