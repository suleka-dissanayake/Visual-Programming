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

namespace StudentDatabaseApp
{
    public partial class Form1 : Form
    {
        config o = new config();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    string qry = "INSERT INTO [Table] (name, gender, address, dob)VALUES('"+textBox1.Text+"', '"+comboBox1.Text+"', '"+textBox2.Text+"', '"+ dateTimePicker1.Value.ToString("yyyy/MM/dd") + "')";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Stored");
                }
                else
                {
                    MessageBox.Show("All FIELDS ARE REQUIRED");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
        }
    }
}
