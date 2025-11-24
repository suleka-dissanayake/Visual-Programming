using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibraryDC
{
    internal class Book
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int No_of_Copies { get; set; }
        public string Category { get; set; }

        string myconnstrng = "server=127.0.0.1; user=root database=librarydb password=;";

        public DataTable Select()
        {
            MySqlConnection con = new MySqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM book";
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

        public bool Insert(Book b)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO book (BookID, Title, Author, Year, No_of_Copies, Category) VALUES (@BookID, @Title, @Author, @Year, @No_of_Copies, @Category)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@BookID", b.BookID);
                cmd.Parameters.AddWithValue("@Title", b.Title);
                cmd.Parameters.AddWithValue("@Author", b.Author);
                cmd.Parameters.AddWithValue("@Year", b.Year);
                cmd.Parameters.AddWithValue("@No_of_Copies", b.No_of_Copies);
                cmd.Parameters.AddWithValue("@Category", b.Category);
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


        public bool Delete(Book b)
        {
            bool isSuccess = false;
            MySqlConnection con = new MySqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM book WHERE BookID=@BookID";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@BookID", b.BookID);
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
