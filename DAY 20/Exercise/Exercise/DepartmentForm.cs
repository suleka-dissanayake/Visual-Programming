using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class DepartmentForm : Form
    {
        string conn = "server=127.0.0.1; database=econtact; user=root; pwd=;";
        Departments dep = new Departments();

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            DataTable dt = dep.Select();
            dataGridView1.DataSource = dt;
        }

        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            dep.Name = textBox1.Text.Trim();
            dep.Head = textBox2.Text.Trim();

            bool success = dep.Insert(dep);

            if (success)
            {
                MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = dep.Select();
                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Failed to add a department. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)//update
        {
            dep.Name = textBox1.Text.Trim();
            dep.Head = textBox2.Text.Trim();

            bool success = dep.Update(dep);

            if (success)
            {
                MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DataTable dt = dep.Select();
                dataGridView1.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Failed to add a department. Please check your connection or data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
