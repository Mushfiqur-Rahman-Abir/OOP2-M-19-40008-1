using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

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

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public Student()
        {
            Console.WriteLine("Student Created with default.");
        }

        public Student(string name, string id, string department, float cgpa)
        {
            Console.WriteLine("Student Created with 4 parameters.");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("ID is: " + id);
            Console.WriteLine("Department is: " + department);
            Console.WriteLine("Cgpa is: " + cgpa);
        }



    }
}
