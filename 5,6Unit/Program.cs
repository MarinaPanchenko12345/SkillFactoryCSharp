using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string FirstName, string LastName, int Age, bool HasPet, string[] PetNames, string[] FavoriteColors) User;

            // --- имя---
            Console.WriteLine("Enter your first name: ");
            User.FirstName = Console.ReadLine();

            // --- фамилия ---
            Console.WriteLine("\nEnter your last name: ");
            User.LastName = Console.ReadLine();

            // --- возраст ---
            int age;
            while (true)
            {
                Console.Write("\nEnter your age (>0): ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Error: Please enter an integer greater than 0.");
            }
            User.Age = age;


            // --- есть ли питомцы ---
            Console.Write("\nDo you have a pet? (yes/no): ");
            User.HasPet = Console.ReadLine().Trim().ToLower() == "yes";
            // --- питомцы только если есть ---
            if (User.HasPet)
            {
                int petCount;
                while (true)
                {
                    Console.Write("How many pets do you have (>0): ");
                    string str = Console.ReadLine();
                    if (int.TryParse(str, out petCount) && petCount > 0)
                        break;
                    else
                        Console.WriteLine("Error: Please enter an integer greater than 0.");
                }
                User.PetNames = GetPetsNames(petCount);
            }
            else
            {
                User.PetNames = new string[0];
            }


            // --- любимые цвета ---
            int colorCount;
            while (true)
            {
                Console.Write("\nHow many favorite colors (>0): ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out colorCount) && colorCount > 0)
                    break;
                else
                    Console.WriteLine("Error: Please enter an integer greater than 0.");
            }
            User.FavoriteColors = GetFavoriteColors(colorCount);

            PrintUser(User);
            Console.ReadLine();
        }


        // --- метод для ввода имен питомцев ---
        static string[] GetPetsNames(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($" Enter the name of  {i + 1} ");
                result[i] = Console.ReadLine();
            }
            return result;
        }

        // --- метод для ввода любимых цветов ---
        static string[] GetFavoriteColors(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Enter the color {i + 1} ");
                result[i] = Console.ReadLine();
            }
            return result;
        }
        // --- метод для вывода информации о пользователе ---
        static void PrintUser((string FirstName, string LastName, int Age, bool HasPet, string[] PetNames, string[] FavoriteColors) user)
        {
            Console.WriteLine();
            Console.WriteLine($"Your First Name: {user.FirstName}");
            Console.WriteLine($"Your Last Neme: {user.LastName}");
            Console.WriteLine($"Your age: {user.Age}");
            Console.WriteLine(user.HasPet ? $"You have a pets: {string.Join(", ", user.PetNames)}" : "You don't have pets.");
            Console.WriteLine($"You have a favorite colors  : {string.Join(", ", user.FavoriteColors)}");
        }

    }
}
