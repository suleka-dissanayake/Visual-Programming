using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Databaseconn
{
    public partial class Form1 : Form
    {
        String conn = ConfigurationManager.ConnectionStrings["connectionS"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn);
            try
            {
                con.Open();
                MessageBox.Show("Succeeded!");

            } 
            
            catch 
            {
                MessageBox.Show("Failed!");
            }

            finally
            {
                con.Close();
            }
        }
    }
}
