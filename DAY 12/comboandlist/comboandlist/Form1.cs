using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboandlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_selected(object sender, EventArgs e)
        {
           
            
        }

        private void cmbstream_selected(object sender, EventArgs e)
        {
            lstSubjects.Items.Clear();


            switch (cmbStream.SelectedIndex)//0
            {
                case 0: // Science
                    lstSubjects.Items.Add("Physics");
                    lstSubjects.Items.Add("Chemistry");
                    lstSubjects.Items.Add("Biology");
                    lstSubjects.Items.Add("Mathematics");
                    break;

                case 1: // Commerce
                    lstSubjects.Items.Add("Accounting");
                    lstSubjects.Items.Add("Economics");
                    lstSubjects.Items.Add("Business Studies");
                    lstSubjects.Items.Add("Mathematics");
                    break;

                case 2: // Arts
                    lstSubjects.Items.Add("History");
                    lstSubjects.Items.Add("Geography");
                    lstSubjects.Items.Add("Political Science");
                    lstSubjects.Items.Add("Sociology");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)//>
        {
            if (lstSubjects.SelectedItem != null)
            {
                lstSelected.Items.Add(lstSubjects.SelectedItem);
                lstSubjects.Items.Remove(lstSubjects.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in lstSubjects.Items)//
            {
                lstSelected.Items.Add(item);
            }
            lstSubjects.Items.Clear();
        }
       /* foreach (var item in collection)
  {
    // Code to do something with item
   }*/

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSubjects.Items.Add(lstSelected.SelectedItem);
                lstSelected.Items.Remove(lstSelected.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in lstSelected.Items)
            {
                lstSubjects.Items.Add(item);
            }
            lstSelected.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
