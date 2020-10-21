using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileChallenge
{
    public partial class Form1 : Form
    {
        public string path = @"C:\Users\Xavier\Documents\StandardDataSet.csv";
        ArrayList people = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parseCSV();
            updateListBox();
        }
        public void parseCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                //MessageBox.Show(parser.ReadLine());
                string firstLine = parser.ReadLine();
                string[] firstFields = firstLine.Split(',');

                while (!parser.EndOfData)
                {
                    string line = parser.ReadLine();
                    string[] fields = line.Split(',');
                    var personByValues = new Dictionary<string, string>();
                    personByValues.Add(firstFields[0], fields[0]);
                    personByValues.Add(firstFields[1], fields[1]);
                    personByValues.Add(firstFields[2], fields[2]);
                    personByValues.Add(firstFields[3], fields[3]);
                    dynamic person = CreateInstance(personByValues);
                    people.Add(new PersonModel(person.FirstName, person.LastName, Convert.ToInt32(person.Age), Convert.ToBoolean(Convert.ToInt32(person.IsAlive))));
                    
                }
            }
            
        }
        public void updateCSV()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("FirstName,LastName,Age,IsAlive");
                foreach (PersonModel person in people)
                {
                    writer.WriteLine(person.FirstName + "," + person.LastName + "," + person.Age + "," + Convert.ToInt32(person.IsAlive));
                }
            }
        }
        public void updateListBox()
        {
            listBox1.Items.Clear();
            foreach(PersonModel person in people)
            {
                if(person.IsAlive)
                    listBox1.Items.Add(person.FirstName + " " + person.LastName + " is " + person.Age + " and is alive");
                else
                    listBox1.Items.Add(person.FirstName + " " + person.LastName + " is " + person.Age + " and is dead");
            }
        }

        public void addUser(string fName, string lName, int age, bool isAlive)
        {
            people.Add(new PersonModel(fName, lName, age, isAlive));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUser(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value), checkBox1.Checked);
            updateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateCSV();
        }

        //WITH THIS FUNCTION WE CAN CREATE AN INSTANCE OF A CLASS WITH A DICTIONARY
        public static dynamic CreateInstance(Dictionary<string, string> objectFromFile)
        {
            dynamic instance = new ExpandoObject();

            var instanceDict = (IDictionary<string, object>)instance;

            foreach (var pair in objectFromFile)
            {
                instanceDict.Add(pair.Key, pair.Value);
            }

            return instance;
        }
    }
}
