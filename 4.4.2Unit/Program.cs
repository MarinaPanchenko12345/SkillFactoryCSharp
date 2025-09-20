using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4._2Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            var anketa = (name: "Line", age: 27);

            Console.WriteLine("Your Name: {0}", anketa.name);
            Console.WriteLine("Your age: {0}", anketa.age);



            Console.WriteLine("Please, enter your name and age again");
            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();
            Console.Write("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: {0}", anketa.name);
            Console.WriteLine("Your age: {0}", anketa.age);

            Console.ReadKey();



            //var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Моё имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);


        }
    }

}
