using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            if (availableBooks.SelectedItem != null)
            {
                string selectedBook = availableBooks.SelectedItem.ToString();
                borrowedBooks.Items.Add(selectedBook);
                availableBooks.Items.Remove(selectedBook);
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.");
            }
        }

        private void return_book_Click(object sender, EventArgs e)
        {
            if (borrowedBooks.SelectedItem != null)
            {
                string selectedBook = borrowedBooks.SelectedItem.ToString();
                availableBooks.Items.Add(selectedBook);
                borrowedBooks.Items.Remove(selectedBook);
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
