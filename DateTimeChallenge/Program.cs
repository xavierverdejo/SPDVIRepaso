using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            readDate();
            readTime();
            Console.ReadKey();
        }
        private static void readDate()
        {
            Console.WriteLine("Please introduce a date. ");
            DateTime dateTime;
            DateTime now = DateTime.Now;
            if(DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.WriteLine("Days between today and the input date: " + (int)((now - dateTime).TotalDays));
            }
            else
            {
                Console.WriteLine("Invalid date format");
            }
        }
        private static void readTime()
        {
            Console.WriteLine("Please introduce a time. ");
            DateTime dateTime;
            DateTime now = DateTime.Now;
            if (DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.WriteLine("Hours between: " + (now.Hour - dateTime.Hour));
                Console.WriteLine("Minutes between: " + (now.Minute - dateTime.Minute));
            }
            else
            {
                Console.WriteLine("Invalid date format");
            }
        }
    }
}
