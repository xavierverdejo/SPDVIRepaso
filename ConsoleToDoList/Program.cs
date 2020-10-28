using System;

namespace ConsoleToDoList
{
    class Program
    {
        public static Writer Logger = new Writer();
        public static CommandHandler Handler = new CommandHandler(Logger);
        static void Main(string[] args)
        {
            Logger.Write("Hello to the ToDo List! Type Help to show all the commands.");
            while(true)
            {
                Handler.parseCommand(Console.ReadLine());
            }
        }
    }
}
