using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPro
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstNumber = 0;
        double secondNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
        }

        private void two_Click(object sender, EventArgs e)
        {
            
        }

        private void three_Click(object sender, EventArgs e)
        {
           
        }

        private void six_Click(object sender, EventArgs e)
        {
            
        }

        private void nine_Click(object sender, EventArgs e)
        {
           
        }

        private void eight_Click(object sender, EventArgs e)
        {
          
        }

        private void five_Click(object sender, EventArgs e)
        {
        }

        private void four_Click(object sender, EventArgs e)
        {
           
        }

        private void seven_Click(object sender, EventArgs e)
        {
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
           
        }

        private void div_Click(object sender, EventArgs e)
        {
            
        }

        private void mul_Click(object sender, EventArgs e)
        {
          
        }

        private void sub_Click(object sender, EventArgs e)
        {
          
        }

        private void add_Click(object sender, EventArgs e)
        {
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            ans.Clear();
            
        }

        private void CE_Click(object sender, EventArgs e)
        {
            ans.Clear();
        }

        private void plusorm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ans.Text))
            {
                double value = Convert.ToDouble(ans.Text);
                value = -value;   // Flip sign
                ans.Text = value.ToString();
            }
        }

        private void pow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ans.Text))
            {
                double value = Convert.ToDouble(ans.Text);
                double result = Math.Pow(value, 2); 
                ans.Text = result.ToString();
            }
        }

        private void module_Click(object sender, EventArgs e)
        {
           
        }

        private void squrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ans.Text))
            {
                double value = Convert.ToDouble(ans.Text);

                if (value >= 0)
                {
                    double result = Math.Sqrt(value);
                    ans.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Cannot calculate square root of a negative number!");
                }
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {

            if (ans.Text == "")
                ans.Text = "0.";  // Start with 0 if empty
            else
                ans.Text += ".";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = ans.Text;
                expression = expression.Replace("×", "*");
                expression = expression.Replace("÷", "/");
                var result = new DataTable().Compute(expression, null);
                ans.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Expression!");
            }
        }

        private void inv_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(ans.Text);

                if (value == 0)   
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }

                double result = 1 / value;
                ans.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
            }
        }

      

        private void remove_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ans.Text))
            {
                ans.Text = ans.Text.Substring(0, ans.Text.Length - 1);
            }
        }

        private void Numberandop_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ans.Text += btn.Text;
        }
    }
}


