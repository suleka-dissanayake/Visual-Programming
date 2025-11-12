using Econtact.econtactclasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Econtact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        contactclass c = new contactclass();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            d1.DataSource = dt;
        }
        void clear()
        {
            t2.Text = "";
            t1.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            c1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c.FirstName = t2.Text.Trim();
            c.LastName = t3.Text.Trim();
            c.ContactNo = t4.Text.Trim();
            c.Address = t5.Text.Trim();
            c.Gender = c1.Text; 

            bool success = c.insert(c);

            if (success)
            {
                MessageBox.Show("Contact added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = c.select();
                d1.DataSource = dt;
 

            }
            else
            {
                MessageBox.Show("Failed to add contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rowheader(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            t1.Text = d1.Rows[rowindex].Cells[0].Value.ToString();
            t2.Text = d1.Rows[rowindex].Cells[1].Value.ToString();
            t3.Text = d1.Rows[rowindex].Cells[2].Value.ToString();
            t4.Text = d1.Rows[rowindex].Cells[3].Value.ToString();
            t5.Text = d1.Rows[rowindex].Cells[4].Value.ToString();
            c1.Text = d1.Rows[rowindex].Cells[5].Value.ToString();





        }

        private void Update_Click(object sender, EventArgs e)
        {
            c.ContactID=int.Parse(t1.Text);
            c.FirstName = t2.Text.Trim();
            c.LastName = t3.Text.Trim();
            c.ContactNo = t4.Text.Trim();
            c.Address = t5.Text.Trim();
            c.Gender = c1.Text;
            bool success = c.Update(c);

            if (success)
            {
                MessageBox.Show("Contact updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = c.select();
                d1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(t1.Text);
           
            bool success = c.Delete(c);

            if (success)
            {
                MessageBox.Show("Contact deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dt = c.select();
                d1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string conn = "server=127.0.0.1;database=econtact;user=root;pwd=;";
        private void t6_TextChanged(object sender, EventArgs e)
        {
            string t= t6.Text;
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string q = "SELECT * FROM Econtact " +
                  "WHERE FirstName LIKE @search OR " +
                  "LastName LIKE @search OR " +
                  "ContactNo LIKE @search OR " +
                  "Address LIKE @search";
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Parameters.AddWithValue("@search", "%" + t + "%");
             MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

            }

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
