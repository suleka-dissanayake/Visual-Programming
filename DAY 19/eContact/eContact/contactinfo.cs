using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eContact
{
    internal class Contactinfo
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        string myconnstrng = "server=127.0.0.1; user=root; database=econtact; password=;";

        public DataTable Select()
        {
            MySqlConnection con = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM contacttable";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                con.Open();
                adp.Fill(dt);
            }
            catch { }
            finally 
            {
                con.Close();
            }
            return dt;
        }

        public bool Insert(Contactinfo s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO contacttable (FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                
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
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Update(Contactinfo s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE contacttable SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                cmd.Parameters.AddWithValue("@LastName", s.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", s.ContactNo);
                cmd.Parameters.AddWithValue("@Address", s.Address);
                cmd.Parameters.AddWithValue("@Gender", s.Gender);
                cmd.Parameters.AddWithValue("@ContactID", s.ContactID);
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

        public bool Delete(Contactinfo s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM contacttable WHERE ContactID=@ContactID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ContactID", s.ContactID);
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
