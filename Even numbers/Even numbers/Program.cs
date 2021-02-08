using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 40;
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even Number: " +i);
                }
            }
        }
    }
}
