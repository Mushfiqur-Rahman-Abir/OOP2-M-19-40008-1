using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP2_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 9,w;
            Console.WriteLine("Hello World"+x+" "+y);
            Console.WriteLine("Hello World {0} {1}",x,y);
            Console.WriteLine("Hello World {0} and {1}", x, y);
            Console.WriteLine("Addition is: {0}",x + y);
            Console.WriteLine("Subtraction is: {0}", x - y);
            Console.WriteLine("Multiplication is: {0}",x * y);
            Console.WriteLine("Division is: {0}", x / y);
            Console.Write("Enter a Number: ");
            string a = Console.ReadLine();
            w = Int32.Parse(a);
            Console.WriteLine("The Number is: {0}",w);

        }
    }
}
