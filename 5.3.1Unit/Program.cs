using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var somename = "Maik";
            Console.WriteLine(somename);

            GetName(somename);

            Console.WriteLine(somename);


            var someAge = 15;
            Console.WriteLine(someAge);

            ChangeAge(someAge);
            Console.WriteLine(someAge);

            Console.ReadLine();
        }
        static void GetName(string name)
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
        }
    }
}
