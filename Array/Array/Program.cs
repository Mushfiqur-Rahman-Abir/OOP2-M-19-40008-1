using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayReverse");
            
            int [] arr= new int[] {1,2,3,4,5,6,7};
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Array Sum");
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine();

           //Console.WriteLine("Copy Array");

            /*int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            for(int i=0;i< arr2.Length;i++)
            {
                int arr3= arr2[i];
                Console.WriteLine(arr3[i]);
            }*/

            Console.WriteLine("Duplicate finding Array");

            int[] arr4 =new int[] { 1,1,2,3,2,5};
            Console.WriteLine();
            Console.WriteLine("Duplicates are");
            for(int i=0;i<arr4.Length;i++)
            {
                for(int j=i+1;j<arr4.Length;j++)
                {
                    if (arr4[i] == arr4[j])
                        Console.WriteLine(arr4[j]);
                }
            }
        }
    }
}
