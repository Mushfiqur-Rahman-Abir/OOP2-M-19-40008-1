using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifires
{
    public class Student
    {
        string name;
        string id;
        float cgpa;

        /*internal void SetName(string name)
        {
            this.name = name;
        }*/

        readonly int credit;

        //Properties or accessors

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public float Cgpa
        {
            get { return cgpa; }
        }



        public Student()
        {
            Console.WriteLine("Student Created with default.");
            credit = 148;
        }

        public Student(string name)
        {
            Console.WriteLine("Student Created with 1 parameter.");
        }

        public Student(string name, string id)
        {
            Console.WriteLine("Student Created with 2 parameter.");
            this.name = name;
            this.id = id;
            credit = 148;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("ID is: " + id);
            Console.WriteLine("Cgpa is: " + cgpa);
        }
    }
}
