using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);//256 error
            Console.ReadKey();



            Console.Write("Enter your name: ");
            var name1 = Console.ReadLine();
            Console.Write("Hello: " + name1);
            Console.Write("Enter your age: ");
            var age1 = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("Your age: " + age1);


        }
    }
}
