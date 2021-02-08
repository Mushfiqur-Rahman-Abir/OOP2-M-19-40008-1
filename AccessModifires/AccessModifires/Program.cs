using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifires;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56; //literals
            const int credit = 148;
            a = 45;

            int n=48; //declaeration
            Console.WriteLine("n is: " + n);

            Student s1 = new Student("ABIR","19-40008-1");
            
            s1.Name = "MUSHFIQUR";
            s1.Id = "19-40008-2";
            Console.WriteLine("Name: " + s1.Name);
            s1.ShowInfo();
        }
    }
}
