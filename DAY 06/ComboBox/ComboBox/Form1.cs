﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            if(comboBox1.SelectedItem != null)
            {
                label2.Text = $"Selected city: {comboBox1.SelectedItem.ToString()}";
            }
            else
            {
                label2.Text = "None were selected!";
            }
        }
    }
}
