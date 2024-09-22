using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Book
{
    internal class Book
    {
        private string ISBN; // ISBN is books uniq serial number
        private string Title;
        private string Author;
        private string Publisher;
        private Category Category;
        private DateTime loanDate; // the date that users borrowed a book
        private DateTime dueDate;  // the date that users must return the book before it and it initialized by librarian
        private bool isBorrowed;

        // the constructor
        public Book(string isbn, string title, string author, string publisher, Category category, bool isborrowed)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Category = category;
        }
        // Getters and Setters
        public string isbn   // property
        {
            get { return ISBN; }   // get method
            set { ISBN = value; }  // set method
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string author
        {
            get { return Author; }
            set { Author = value; }
        }
        public string publisher
        {
            get { return Publisher; }
            set { Publisher = value; }
        }
        public Category category
        {
            get { return Category; }
            set { Category = value; }
        }
        public DateTime loandate
        {
            get { return loanDate; }
            set { loanDate = value; }
        }
        public bool isborrowed
        {
            get { return isBorrowed; }
            set { isBorrowed = value; }
        }

        public void update()
        {
            Console.WriteLine("the library properties are updated");
        }

        // check if any problem may exist with borrowing books or not
        public void issueLoan()
        {
            if (loanDate > dueDate && isBorrowed == true)
            //&& User.fine>=0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}
