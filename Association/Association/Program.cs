using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Musfiqur","19-40008-1",3.57f);
            Student s2 = new Student("Shuvo", "19-40022-1", 3.77f);
            Student s3 = new Student("Barshan", "19-40128-2", 3.7f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrionic Electical Engineering", "EEE");

            s1.Dept = d1;
            d1.AddStudent();

            s2.Dept = d1;
            s3.Dept = d2;
            //d2.AddStudent(s3);
            s1.ShowSudentDeatils();
            s3.ShowSudentDeatils();
            Console.WriteLine("**********************");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowSudentDeatils();
        }
    }
}
