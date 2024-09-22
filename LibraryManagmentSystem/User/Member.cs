using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string search()
        {
            return "";// returning search result
        }
    }
}
