using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3._7Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            var name = Console.ReadLine();

            Console.WriteLine("Your name in reverse order: ");

            for (int i = name.Length-1 ; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}
