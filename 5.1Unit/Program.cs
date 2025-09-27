using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name,string[] favfood) User;


            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();

            User.favfood = new string[5];
            for (int a = 0; a <User.favfood.Length; a++)
            {
                Console.WriteLine($"Enter your favorite food {a + 1}: ");
                User.favfood[a] = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
