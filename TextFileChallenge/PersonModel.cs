using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileChallenge
{
    public class PersonModel
    {

        public PersonModel(string firstName, string lastName, int age, bool isAlive)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.IsAlive = isAlive;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsAlive { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
