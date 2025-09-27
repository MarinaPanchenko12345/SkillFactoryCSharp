using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4Unit
{
    internal class Program
    {
        static int num1 = 6677;

        static int Sum()
        {
            var num2 = 1;
            return num1 + num2;

        }
        static void Main(string[] args)
        {

            Console.WriteLine(num1);
            Console.WriteLine(Sum());
            if (num1 > 0)
            {
                var num3 = 5;
                Console.WriteLine(num1 + num3);
            }
        }
    }
}
