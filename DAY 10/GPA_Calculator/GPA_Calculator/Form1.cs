using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String RegNo = maskedTextBox2.Text;
            String IndexNo = maskedTextBox3.Text;
            String Name = maskedTextBox1.Text;
            int VP_T_Marks = int.Parse(maskedTextBox4.Text);
            int VP_T_Credit = int.Parse(maskedTextBox6.Text);
            int VP_P_marks = int.Parse(maskedTextBox5.Text);
            int VP_P_Credit = int.Parse(maskedTextBox7.Text);
            int CG_T_Marks = int.Parse(maskedTextBox11.Text);
            int CG_T_Credit = int.Parse(maskedTextBox9.Text);
            int CG_P_Marks = int.Parse(maskedTextBox10.Text);
            int CG_P_Credit = int.Parse(maskedTextBox8.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }
    }
}
