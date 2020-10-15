using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForeachChallenge
{
    class PersonModel
    {
        string firstName, lastName;

        public PersonModel(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
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
    }
}
