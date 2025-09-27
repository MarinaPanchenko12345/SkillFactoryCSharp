using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            var array = GetArrayFromConsole(ref num);

            Console.WriteLine(string.Join(" ", array));
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num]; ;

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Enter element of array number  {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void GetAge(string Name, byte Age)
        {

        }
    }
}
