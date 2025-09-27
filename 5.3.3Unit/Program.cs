using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._3Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";        
            ChangeName(ref name);        
            Console.WriteLine(name);
        }
        static void ChangeName(ref string name)
        {
            Console.Write("Enter name : ");
            name = Console.ReadLine();
        }
    }
}
