using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eContact
{
    internal class contactinfo
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public DataTable select()
        {
            MySqlConnection con = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from ContactTable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                con.Open();
                adp.Fill(dt);
            }
            catch
            {

            }
            finally
            {

            }
            return dt;
        }

        public bool insert(contactinfo s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "insert into ContactTable (FirstName, LastName, ContactNo, Address, Gender) Values(@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                cmd.Parameters.AddWithValue("@LastName", s.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", s.ContactNo);
                cmd.Parameters.AddWithValue("@Address", s.Address);
                cmd.Parameters.AddWithValue("@Gender", s.Gender);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {

                }
            }
            catch
            {

            }
            finally
            {

            }
            return isSuccess;
        }
    }
}
