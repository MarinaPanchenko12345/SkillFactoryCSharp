using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "John";
            byte MyAge = 25;
            bool HaveIApet=true;
            double MyShoeSize = 37.5;


            Console.WriteLine("My name is " + MyName );
            Console.WriteLine("I am " + MyAge + " years old");
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.WriteLine( "Do I have a pet? " + HaveIApet);

        }
    }
}
