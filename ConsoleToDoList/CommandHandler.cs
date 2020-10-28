using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDoList
{
    class CommandHandler
    {
        Writer Logger;
        ArrayList toDoItems = new ArrayList();
        public CommandHandler(Writer writer)
        {
            this.Logger = writer;
        }
        public void parseCommand(string text)
        {
            string command;
            try
            {
                command = text.Substring(0, text.IndexOf(" "));
            }
            catch(Exception e)
            {
                command = text;
            }
            text = text.Substring(text.IndexOf(" ")+1);
            switch (command)
            {
                default:
                    Logger.WriteWarning("Please type a correct option.");
                    break;
                case "Add":
                    Logger.WriteDone("Added ToDo Item: " + text + " with id " + addTodo(text));
                    break;
                case "Print":
                    printTop();
                    break;
                case "PrintAll":
                    printAll();
                    break;
                case "Done":
                    setDone(Convert.ToInt32(text));
                    break;
                case "ReOrder":
                    int index = Convert.ToInt32(text.Split(" ")[0]);
                    int nIndex = Convert.ToInt32(text.Split(" ")[1]);
                    reOrder(index, nIndex);
                    break;
                case "Help":
                    writeHelp();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }
        public void reOrder(int index, int newIndex)
        {
            ToDoItem temp = (ToDoItem)toDoItems[index];
            toDoItems.RemoveAt(index);
            toDoItems.Insert(newIndex, temp);
        }
        public void setDone(int index)
        {
            ToDoItem temp = (ToDoItem)toDoItems[index];
            temp.complete = true;
            toDoItems[index] = temp;
        }
        public void writeHelp()
        {
            Logger.WriteWarning("HELP COMMAND EXECUTED\n" +
                "Add <todo> - This command will add a to-do task to the list.\n" +
                "Print - This command will show the 3 firsts tasks to-do.\n" +
                "PrintAll - This command will show you all the tasks to-do.\n" +
                "Done <todo-id> - Change <todo-id> with the id of the selected to-do task shown in the Print command. This command will change the state of the task to completed.\n" +
                "ReOrder <id> <newPosition> - Change the order of the to-do tasks.\n" +
                "Exit - Close the program.");

        }
        public int addTodo(string args)
        {
            toDoItems.Add(new ToDoItem(args, toDoItems.Count));
            return toDoItems.Count - 1;
        }
        public void printAll()
        {
            foreach(ToDoItem item in toDoItems)
            {
                Logger.WriteItem(item);
            }
        }
        public void printTop()
        {
            for(int i = toDoItems.Count-1; i>(toDoItems.Count-4); i--)
            {
                //Logger.Write("" + i);
                Logger.WriteItem((ToDoItem)toDoItems[i]);
            }
        }
    }
}
