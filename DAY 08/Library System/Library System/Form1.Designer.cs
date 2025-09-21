namespace Library_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.availableBooks = new System.Windows.Forms.ListBox();
            this.borrowedBooks = new System.Windows.Forms.ListBox();
            this.borrow = new System.Windows.Forms.Button();
            this.return_book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableBooks
            // 
            this.availableBooks.FormattingEnabled = true;
            this.availableBooks.Items.AddRange(new object[] {
            "Harry Potter",
            "The Hobbit",
            "Sherlock Holmes",
            "Pride and Prejudice"});
            this.availableBooks.Location = new System.Drawing.Point(41, 41);
            this.availableBooks.Name = "availableBooks";
            this.availableBooks.Size = new System.Drawing.Size(144, 186);
            this.availableBooks.TabIndex = 0;
            this.availableBooks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // borrowedBooks
            // 
            this.borrowedBooks.FormattingEnabled = true;
            this.borrowedBooks.Location = new System.Drawing.Point(367, 41);
            this.borrowedBooks.Name = "borrowedBooks";
            this.borrowedBooks.Size = new System.Drawing.Size(144, 186);
            this.borrowedBooks.TabIndex = 1;
            this.borrowedBooks.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(236, 70);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(75, 23);
            this.borrow.TabIndex = 2;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // return_book
            // 
            this.return_book.Location = new System.Drawing.Point(236, 138);
            this.return_book.Name = "return_book";
            this.return_book.Size = new System.Drawing.Size(75, 23);
            this.return_book.TabIndex = 3;
            this.return_book.Text = "Return";
            this.return_book.UseVisualStyleBackColor = true;
            this.return_book.Click += new System.EventHandler(this.return_book_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 300);
            this.Controls.Add(this.return_book);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.borrowedBooks);
            this.Controls.Add(this.availableBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox availableBooks;
        private System.Windows.Forms.ListBox borrowedBooks;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button return_book;
    }
}

