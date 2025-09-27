using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2Unit
{
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            //Console.Write($"{username},{userage} \nWrite your favorite color in English with a lowercase letter: ");
            Console.Write($"{0},{1} \nWrite your favorite color in English with a lowercase letter: ", username, userage);
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your color is red!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;

                default:
                    Console.ResetColor();
                    Console.WriteLine("Unknown color.");
                    break;
            }

        
            return color;
        }

        static void Main(string[] args)
        {
            (string name, int age) anketa;


            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: {0}", anketa.name);
            Console.WriteLine("Your age: {0}", anketa.age);


            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
                favcolors[i] = ShowColor(anketa.name, anketa.age);

            Console.WriteLine("Your favorite colors:");
            foreach (var color in favcolors)
                Console.WriteLine(color);


            Console.ReadKey();
        }
    }
}
