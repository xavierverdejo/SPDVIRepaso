using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDoList
{
    public class Writer
    {
        public Writer()
        {

        }
        public void WriteDone(string line)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(line);
            setDefault();
        }
        public void WriteTodo(string line)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(line);
            setDefault();
        }
        public void Write(string line)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(line);
            setDefault();
        }
        public void WriteWarning(string line)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(line);
            setDefault();
        }
        public void WriteItem(ToDoItem item)
        {
            if (item.complete)
                WriteDone(item.ToString());
            else
                WriteTodo(item.ToString());
        }
        public void setDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
