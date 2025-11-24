using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Exercise
{
    internal class Departments
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        public string Head { get; set; }

        string myconnstrng = "server=127.0.0.1; user=root; database=departmentdb; password=;";

        public DataTable Select()
        {
            MySqlConnection con = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM department";
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

        public bool Insert(Departments d)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO department (Name, EmployeeCount, Head) VALUES (@Name, @EmployeeCount, @Head)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", d.Name);
                cmd.Parameters.AddWithValue("@EmployeeCount", d.EmployeeCount);
                cmd.Parameters.AddWithValue("@Head", d.Head);
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

        public bool Update(Departments d)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE department SET Name=@Name, EmployeeCount=@EmployeeCount, Head=@Head WHERE StaffID=@StaffID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", d.Name);
                cmd.Parameters.AddWithValue("@EmployeeCount", d.EmployeeCount);
                cmd.Parameters.AddWithValue("@Head", d.Head);
                cmd.Parameters.AddWithValue("@StaffID", d.StaffID);
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

        public bool Delete(Departments d)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM department WHERE StaffID=@StaffID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@StaffID", d.StaffID);
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
