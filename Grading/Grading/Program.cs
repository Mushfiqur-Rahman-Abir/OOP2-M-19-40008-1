using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int phy = 80;
            int che = 73;
            int bio = 65;
            int math = 60;
            int Com = 90;
            a = ((phy * 3) + (che * 3) + (bio * 3) + (math * 3) + (Com * 3)) / 12;
            if (a >= 90)
            {
                Console.WriteLine("GRADE A+");
            }
            else if (a >= 85 && a <= 89)
            {
                Console.WriteLine("GRADE A");
            }
            else if (a >= 80 && a <= 85)
            {
                Console.WriteLine("GRADE B+");
            }
            else if (a >= 75 && a <= 79)
            {
                Console.WriteLine("GRADE B");
            }
            else if (a >= 50 && a <= 75)
            {
                Console.WriteLine("GRADE C+ ");
            }
            else
            {
                Console.WriteLine("GRADE F");
            }
        }
    }
}