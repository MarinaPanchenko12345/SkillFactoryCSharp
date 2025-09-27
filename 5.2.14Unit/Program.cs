using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._14Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //SortComplexArray(arr);
            GetArrayFromConsole();

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

        //static void SortComplexArray(int[,] arr)
        //{
        //    int temp;
        //    for (int i = 0; i <= arr.GetUpperBound(0); i++)
        //    {
        //        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        //            for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
        //                if (arr[i, j] > arr[i, k])
        //                {
        //                    temp = arr[i, k];
        //                    arr[i, k] = arr[i, j];
        //                    arr[i, j] = temp;
        //                }
        //    }
        //}
    }
}
