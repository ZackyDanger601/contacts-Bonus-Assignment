using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts
{
    class contact
    {
        private string firstName;
        private string lastName;
        private string phoneNum;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phone
        {
            get { return phoneNum; }
            set
            {
                if (value.Length == 10)
                {
                    phoneNum = value;
                }
                else
                {
                    phoneNum = "0000000000";
                }
            }
        }

        public contact()
        {
            FirstName = "John";
            LastName = "Lennon";
            Phone = "0000000000";
        }

        public contact(string firstName, string lastName, string Phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phoneNum;
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1} ", LastName, FirstName);
            output += String.Format("({0}) {1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 3), Phone.Substring(6, 4));

            return output;
        }
    }
}
