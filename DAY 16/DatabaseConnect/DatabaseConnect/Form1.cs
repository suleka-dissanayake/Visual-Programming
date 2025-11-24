using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;//
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//

namespace DatabaseConnect
{
    public partial class Form1 : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["connectionS"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try {
                con.Open();
                MessageBox.Show("Scuccessfully connected!");
            }
            catch {
                MessageBox.Show("Connection failed!");
            }
            finally {
                con.Close();
            }
        }
    }
}
