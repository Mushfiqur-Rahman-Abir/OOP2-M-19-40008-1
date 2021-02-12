using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPassValRef
{
    class Program
    {

        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x= {0} & y= {1}", x, y);
        }
        static void Main(string[] args)
        {
            int x = 10,y= 12;
            Console.WriteLine("x= {0} & y= {1}",x,y);
            swap(x,y);
           Student s1 = new Student("Abir","19-40008-1");
            Student s2 = new Student("Sabir", "20-50009-2");
            Console.WriteLine("The Student name is: " +s1.Name + "\nThe Student Id is: " +s1.Id );
            Console.WriteLine("The Student name is: " + s2.Name + "\nThe Student Id is: " + s2.Id);
            Console.WriteLine("The number of Student's are: " + Student.count);

        }
    }
}
