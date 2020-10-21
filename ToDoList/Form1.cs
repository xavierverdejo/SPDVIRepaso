using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        ArrayList toDoItems = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ADD ITEM
            toDoItems.Add(new ToDoItem(textBox1.Text, toDoItems.Count));
            updateListBox();
        }
        public void updateListBox()
        {
            toDoList.Items.Clear();
            toDoList.Items.AddRange(toDoItems.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = toDoItems.IndexOf(toDoList.SelectedItem);
            toDoItems.RemoveAt(id);
            updateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // EDIT
            int id = toDoItems.IndexOf(toDoList.SelectedItem);
            ToDoItem temp = (ToDoItem)toDoItems[id];
            temp.toDoText = textBox1.Text;
            toDoItems[id] = temp;
            updateListBox();
        }
        void doubleClicked(object sender, MouseEventArgs e)
        {
            int index = this.toDoList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                ToDoItem temp = (ToDoItem)toDoItems[index];
                temp.complete = !temp.complete;
                toDoItems[index] = temp;
                updateListBox();
            }
        }
    }
}
