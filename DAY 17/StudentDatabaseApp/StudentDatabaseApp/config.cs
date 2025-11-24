using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabaseApp
{
    internal class config
    {
        public SqlConnection con;
        public string str;

        public config()
        {
            str = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\2022ICT68\Desktop\Visual Programming\Day 17\StudentDatabaseApp\StudentDatabaseApp\StudentDB.mdf; Integrated Security = True;";

            try
            {
                con = new SqlConnection(str);
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

    }
}
