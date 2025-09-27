using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._5Unit
{
    internal class Program
    {
        static string ShowColor()
        {
            Console.Write("Write your favorite color in English using lowercase letters:");
            string color = Console.ReadLine();
            return color;
        }
        static void Main(string[] args)
        {

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
                favcolors[i] = ShowColor();

            Console.WriteLine("Your favorite colors:");
            foreach (var color in favcolors)
                Console.WriteLine(color);

            Console.ReadKey();
        }
    }
}
