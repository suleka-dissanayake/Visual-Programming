using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Econtact.econtactclasses
{
    internal class contactclass
    {
        
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender{ get; set; }



        string myconnstrng = "server=127.0.0.1;user=root;database=econtact;password=;";



        public DataTable select()
        {
            MySqlConnection con = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_contact";
                MySqlCommand cmd = new MySqlCommand(sql,con);
                MySqlDataAdapter adp= new MySqlDataAdapter(cmd);
                con.Open();
                adp.Fill(dt);

            }
            catch 
            {
            }
            finally
            {
                con.Close();
            }
            return dt;
        }


        public bool insert(contactclass s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);
            try 
            {
                string sql = "insert into tbl_contact(FirstName,LastName,ContactNo,Address,Gender) " +
                    "Values(@FirstName,@LastName,@ContactNo,@Address,@Gender)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                cmd.Parameters.AddWithValue("@LastName", s.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", s.ContactNo);
                cmd.Parameters.AddWithValue("@Address", s.Address);
                cmd.Parameters.AddWithValue("@Gender", s.Gender);
                con.Open() ;
                int rows=cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess= true;
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

        public bool Update(contactclass s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "update tbl_contact set FirstName=@FirstName,LastName=@LastName," +
                    "ContactNo=@ContactNo,Address=@Address,Gender=@Gender where ContactID=@ContactID";
                    
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return isSuccess;

        }

        public bool Delete(contactclass s)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);
            try
            {
                string sql = "Delete from tbl_contact where ContactID=@ContactID";

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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return isSuccess;

        }


    }
}
