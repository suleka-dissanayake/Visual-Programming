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

namespace Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    
                    string qry = "INSERT INTO [Table] (name, gender, address, dob) " +
                                 "VALUES (@name, @gender, @address, @dob)";

                    
                    using (SqlCommand cmd = new SqlCommand(qry, o.con))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@address", textBox2.Text);
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString("yyyy/MM/dd"));

                        
                        cmd.ExecuteNonQuery();
                    }

                    // Notify success
                    MessageBox.Show("Data Stored");
                }
                else
                {
                    // Notify missing fields
                    MessageBox.Show("All FIELDS ARE REQUIRED");
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
