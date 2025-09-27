using System;

namespace _5._3._6Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var data = 5;

            BigDataOperation(arr,ref data);
            Console.WriteLine(arr[0]);

            Console.ReadLine();
        }

        static void BigDataOperation(int[] array,ref int data)
        {
            array[0] = 4;
        }
    }
}
