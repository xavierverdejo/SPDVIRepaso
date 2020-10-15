using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("John");
            names.Add("Mary");
            names.Add("Sue");
            names.Add("Greg");
            names.Add("Yolanda");
            names.Add("Jose");
            names.Add("Bill");
            names.Add("Gates");
            foreach(string name in names)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadKey();

            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel("Tim", "Corey"));
            people.Add(new PersonModel("Bill", "McOy"));
            people.Add(new PersonModel("Mary", "Jones"));
            people.Add(new PersonModel("Steve", "Works"));
            people.Add(new PersonModel("Sue", "Smith"));
            foreach (PersonModel person in people)
            {
                Console.WriteLine("Hello " + person.FirstName + " " + person.LastName);
            }
            Console.ReadKey();
        }
    }
}
