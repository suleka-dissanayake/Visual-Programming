using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    internal class config
    {
        public SqlConnection con;
        public string str;

        public config()
        {
            str = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\2022ict90\Desktop\Second year\Visual Studio\DAY15\Project01\StudentDB.mdf; Integrated Security = True";

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

