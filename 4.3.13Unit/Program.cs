using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3._13Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the sum of all elements in the array.");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            //foreach (int i in arr) 
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Sum: " + sum);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
         

            Console.WriteLine("\nJagged array example:");
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
