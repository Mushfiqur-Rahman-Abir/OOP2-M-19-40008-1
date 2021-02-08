using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Mushfiqur";
            s1.Id = "19-40008-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.56f;
            s1.ShowInfo();

            Student s2 = new Student("ABIR","19-39954-1","EEE",3.77f);
            s2.ShowInfo();

            Triangle t1 = new Triangle();
            t1.ShowInfo();
            Triangle t2 = new Triangle(3, 3, 3);
            t2.ShowInfo();

            Course c1 = new Course();
            c1.CourseName = "OOP 2";
            c1.CourseCode = "10101";
            c1.CourseCredit = 3;
            c1.ShowInfo();

            Course c2= new Course("Web Tech", "20202", 3);
            c2.ShowInfo();

            Account a1 = new Account("ABIR","1111",20000);
            a1.ShowInfo();

            Account a2 = new Account();
            a2.accName = "SABIR";
            a2.acid = "2222";
            a2.balance = 30000;
            a2.ShowInfo();
        }
    }
}
