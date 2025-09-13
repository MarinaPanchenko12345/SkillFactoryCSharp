using System;

namespace EnumDemo
{
    // Можно указывать базовый тип, по умолчанию int
    // public enum SmartPhoneColor : short { Red = 100, Yellow = 200, Green = 300 }
    public enum SmartPhoneColor
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhoneColor c = SmartPhoneColor.Yellow;
            Console.WriteLine(c);          // Yellow
        }
    }
}
