using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Enter your pet's name: ");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Enter your pet's type (dog, cat, etc.): ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Enter your pet's age: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());//Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine($"\nYour pet's name is {Pet.Name}, it is a {Pet.Type}, and it is {Pet.Age} years old. The name has {Pet.NameCount} characters.");
            Console.ReadKey();


        }
    }
}
