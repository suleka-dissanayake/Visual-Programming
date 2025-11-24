using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> stList = new List<Student>()
            {
                new Student(){ Id=1, Name="Alice"},
                new Student(){ Id=2, Name="Bob"},
                new Student(){ Id=3, Name="Charlie"},
            };

            comboBox1.DataSource = stList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            textBox1.DataBindings.Add("Text", stList, "Name");
            dataGridView1.DataSource = stList;
        }
    }
}
