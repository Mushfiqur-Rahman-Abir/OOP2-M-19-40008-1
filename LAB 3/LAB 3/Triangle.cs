using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Triangle
    {
        int x = 3;
        int y = 2;
        int z = 1;

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        public Triangle()
        {
            Console.WriteLine("Triangle Created with default.");
        }

        public Triangle(int x, int y, int z)
        {
            Console.WriteLine("Triangle Created with 3 parameters.");
            this.x = x;
            this.y = y;
            this.z= z;
        }

        public void TestTriangle()
        {
            if (x == y && y == z && x == z)
            {
                Console.WriteLine("The Triangle is Equilateral.");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The Triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The Triangle is Scalene.");
            }
        }
        public void ShowInfo()
        {

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + Z);
        }

    }
}
