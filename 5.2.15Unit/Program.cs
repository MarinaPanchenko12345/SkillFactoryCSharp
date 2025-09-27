using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._15Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            var sortedarray = SortArray(array);
            Console.WriteLine(string.Join(" ", sortedarray));
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num]; ;

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Enter element of array number  {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
    }
}
