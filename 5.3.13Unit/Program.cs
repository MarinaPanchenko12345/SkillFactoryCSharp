using System;
using System.Linq;

namespace _5._3._13Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, 6, 9, 1, 2, -3, -8, 8, 1, 1, 2, -3 };

            SortArray(in arr, out var sorteddesc, out var sortedasc);

            Console.WriteLine("DESC: " + string.Join(" ", sorteddesc));
            Console.WriteLine("ASC : " + string.Join(" ", sortedasc));
        }

        // in — только чтение исходного массива; out — два результата
        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            // копии исходного массива
            sorteddesc = Copy(array);
            sortedasc = Copy(array);

            SelectionSortDesc(sorteddesc);
            SelectionSortAsc(sortedasc);
        }

        static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                copy[i] = array[i];
            return copy;
        }

        // сортировка выбором по возрастанию
        static void SelectionSortAsc(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] < a[minIdx]) minIdx = j;

                int tmp = a[i];
                a[i] = a[minIdx];
                a[minIdx] = tmp;
            }
        }

        // сортировка выбором по убыванию
        static void SelectionSortDesc(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int maxIdx = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] > a[maxIdx]) maxIdx = j;

                int tmp = a[i];
                a[i] = a[maxIdx];
                a[maxIdx] = tmp;
            }
        }
    }
}

//using System;
//using System.Linq;

//namespace _5._3._13Unit
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { -5, 6, 9, 1, 2, -3, -8, 8, 1, 1, 2, -3 };

//            SortArray(in arr, out var sortedDesc, out var sortedAsc);

//            Console.WriteLine("DESC: " + string.Join(" ", sortedDesc));
//            Console.WriteLine("ASC : " + string.Join(" ", sortedAsc));
//        }

//        // in — вход только для чтения; out — результаты
//        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
//        {
//            sorteddesc = SortArrayDesc(array);
//            sortedasc = SortArrayAsc(array);
//        }

//        static int[] SortArrayDesc(int[] source)
//        {
//            var a = source.ToArray();     // копия, чтобы не трогать исходный
//            Array.Sort(a);
//            Array.Reverse(a);
//            return a;
//        }

//        static int[] SortArrayAsc(int[] source)
//        {
//            var a = source.ToArray();     // копия
//            Array.Sort(a);
//            return a;
//        }
//    }
//}
