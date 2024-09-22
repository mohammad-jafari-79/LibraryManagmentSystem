using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagmentSystem.Book;

namespace LibraryManagmentSystem.User
{
    internal class Member : User
    {
        private DateTime membershipDate;
        private int maxBorrow;
        private int borrowNo;
        private double Fine;
        DateTime dateTime = DateTime.UtcNow.Date;
        // the constructor
        public Member(string name, string family, string phonenumber,
        Gender gender, DateTime membershipdate = default) : base(name, family, phonenumber, gender)
        {
            membershipDate = membershipdate == default ? dateTime : membershipdate;
        }
        // Getters and Setters
        public DateTime membershipdate
        {
            get { return membershipDate; }
            set { membershipDate = value; }
        }
        public int maxborrow
        {
            get { return maxBorrow; }
            set { maxBorrow = value; }
        }
        public int borrowno
        {
            get { return borrowNo; }
            set { borrowNo = value; }
        }
        public double fine
        {
            get { return Fine; }
            set { Fine = value; }
        }
        // searching for book
        public string search(string bookName, string authorName)
        {
            // path must be initialized
            string path = ""; // -> temperary initilizing exmple: $"{directory}{fileName}"
            string[] booksListAsString = File.ReadAllLines(path);
            if (string.IsNullOrEmpty(bookName)) // searching by author name
            {
                // reading from file that includes books detail
                for (int i = 0; i < maxBorrow; i++)
                {
                    string[] booksSplit = booksListAsString[i].Split(';');
                    string title = booksSplit[1].Substring(booksSplit[1].IndexOf(':') + 1); // third one must be author name in saving format, ordered by initialization in book class
                    string author = booksSplit[2].Substring(booksSplit[2].IndexOf(':') + 1); // third one must be author name in saving format, ordered by initialization in book class
                    string publisher = booksSplit[3].Substring(booksSplit[3].IndexOf(':') + 1); // third one must be author name in saving format, ordered by initialization in book class
                    if (author.Equals(authorName))
                    {
                        return $"Title: {title}\nAuthor: {author}\nPublisher: {publisher}\n";
                    }
                }
            }
            else if (string.IsNullOrEmpty(authorName)) // searching by book name
            {
                for (int i = 0; i < maxBorrow; i++)
                {
                    string[] booksSplit = booksListAsString[i].Split(';');
                    string title = booksSplit[1].Substring(booksSplit[1].IndexOf(':') + 1); // second one of booksSplit[1] value must be author name in saving format
                    string author = booksSplit[2].Substring(booksSplit[2].IndexOf(':') + 1);
                    string publisher = booksSplit[3].Substring(booksSplit[3].IndexOf(':') + 1);

                    if (bookName.Equals(title))
                    {
                        return $"Title: {title}\nAuthor: {author}\nPublisher: {publisher}\n";
                    }
                }
            }
            return "noting has found";// returning search result
        }
    }
}
