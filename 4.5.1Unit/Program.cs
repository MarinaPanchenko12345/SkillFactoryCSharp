using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5._1Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;


            int z= 0;
            for (z= 0; z < 3; z++)
            {
                Console.Write("\n\nEnter your first name: ");
                User.Name = Console.ReadLine();
                Console.Write("Enter your last name: ");
                User.LastName = Console.ReadLine();
                Console.Write("Enter your login: ");

                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.Write("Do you have a pet? (yes/no): ");
                string hasPetInput = Console.ReadLine().ToLower();
                User.HasPet = hasPetInput == "yes" || hasPetInput == "y";
                Console.Write("How many favorite colors do you have? ");
                int colorCount = Convert.ToInt32(Console.ReadLine());
                User.favcolors = new string[colorCount];
                for (int i = 0; i < colorCount; i++)
                {
                    Console.Write($"Enter favorite color {i + 1}: ");
                    User.favcolors[i] = Console.ReadLine();
                }
                Console.Write("Enter your age: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nUser Information:\nName: {User.Name}\nLast Name: {User.LastName}\nLogin: {User.Login} (Length: {User.LoginLength})\nHas Pet: {User.HasPet}\nAge: {User.Age}\nFavorite Colors: {string.Join(", ", User.favcolors)}");
            }

           
        }
    }
}
