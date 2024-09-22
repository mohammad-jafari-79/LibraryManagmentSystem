using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.User
{
    internal class Manager
    {
        private int id;
        private string name;
        private string family;
        private string phonenumber;
        private Gender gender;
        private double wage;

        public Manager(string name, string family, string phonenumber, Gender gender, double wage)
        {
            id = generateId();
            this.name = name;
            this.family = family;
            this.phonenumber = phonenumber;
            this.gender = gender;
            this.wage = wage;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private int generateId()
        {
            Random number = new Random();
            return number.Next();
        }

        private double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

    }
}
