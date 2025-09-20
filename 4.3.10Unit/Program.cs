using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3._10Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array.Length);

            Console.Write("Number of lines: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Number of columns: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");
        }
    }
}
