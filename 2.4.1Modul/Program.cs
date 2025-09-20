using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("4.1.4");
            string A = "";
            string B = "";
            bool C = A != B;


            //Console.WriteLine("4.1.5");
            //int a;
            //int b;
            //double x;
            //double y;
            //bool c = (a < b) || (x > y);

            Console.WriteLine("4.1.11");
            var a1 = 6;
            var b1 = 7;
            if (a1 == b1) //(a1 != b1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.Write("4.1.13");
            var a3 = 6;
            var b3 = 7;

            if (a3 == b3 && b3 > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b3 > 10 || b3 == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b3);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b3);
            }
        }
    }
}
