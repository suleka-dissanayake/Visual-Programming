using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eContact
{//Install-Package MySql.Data.EntityFramework -Version 8.0.33
    public partial class Form1 : Form
    {
        string conn = "server=127.0.0.1; database=econtact; user=root; pwd=;";
        Contactinfo c = new Contactinfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        public void clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            c.FirstName = textBox2.Text.Trim();
            c.LastName = textBox3.Text.Trim();
            c.ContactNo = textBox4.Text.Trim();
            c.Address = richTextBox1.Text.Trim();
            c.Gender = comboBox1.Text;

            bool success = c.Insert(c);

            if (success)
            {
                MessageBox.Show("Contact added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Failed to add contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)//update
        {
            c.ContactID = int.Parse(textBox1.Text);
            c.FirstName = textBox2.Text.Trim();
            c.LastName = textBox3.Text.Trim();
            c.ContactNo = textBox4.Text.Trim();
            c.Address = richTextBox1.Text.Trim();
            c.Gender = comboBox1.Text;
            bool success = c.Update(c);

            if (success)
            {
                MessageBox.Show("Contact updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)//dlt
        {
            c.ContactID = int.Parse(textBox1.Text);

            bool success = c.Delete(c);

            if (success)
            {
                MessageBox.Show("Contact deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)//search
        {
            string t = textBox6.Text;
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string q = "SELECT * FROM contacttable WHERE" + 
                  "FirstName LIKE @search OR " +
                  "LastName LIKE @search OR " +
                  "ContactNo LIKE @search OR " +
                  "Address LIKE @search";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@search", "%" + t + "%");
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
        }
    }
}
