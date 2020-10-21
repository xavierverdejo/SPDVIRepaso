using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoItem
    {
        public string toDoText {get; set;}
        public int id;
        public bool complete { get; set; }
        public ToDoItem(string text, int id)
        {
            this.toDoText = text;
            this.id = id;
            this.complete = false;
        }

        public override string ToString()
        {
            return id + ": " + toDoText + " (Complete: "+complete+")";
        }

    }
}
