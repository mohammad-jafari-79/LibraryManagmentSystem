using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagmentSystem.User
{
    internal class Librarian : User
    {
        private double wage;
        private int noHoursWork;

        public Librarian(string name, string family, string phonenumber,
            Gender gender) : base(name, family, phonenumber, gender)
        {
        }
    }
}
