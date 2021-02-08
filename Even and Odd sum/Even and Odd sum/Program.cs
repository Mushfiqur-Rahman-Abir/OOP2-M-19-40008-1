using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int e=0;
            int o=0;
            int n = 100;
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    e = e + i;
                }
                else
                    o = o + i;
            }

            Console.WriteLine("Even numbers sum: " +e);
            Console.WriteLine("Even numbers sum: " + o);
        }
    }
}
