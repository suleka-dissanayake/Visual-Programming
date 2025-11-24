using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    internal class UserClass
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

        static string myconnstrng = "server=127.0.0.1;user=root;database=users;password=;";

        public bool checkuser(UserClass s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT UserName, Password where ID=@ID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@UserName", s.UserName);
                cmd.Parameters.AddWithValue("@Password", s.Password);
                cmd.Parameters.AddWithValue("@ID", s.ID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return isSuccess;
        }
    }
}
