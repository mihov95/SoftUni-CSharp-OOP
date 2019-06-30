using System;
using System.Runtime.InteropServices;

namespace _01._Rhombus_Of_Stars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                PrintRow(count, i);
                Console.WriteLine();
            }

            for (int i = count - 1; i >= 0; i--)
            {
                PrintRow(count, i);
                Console.WriteLine();
            }
        }

        private static void PrintRow(int count, int stars)
        {
            int leadingSpace = count - stars;
            Console.Write(new string(' ', leadingSpace));


            for (int i = 0; i < stars; i++)
            {
                Console.Write("* ");
            }
        }
    }
}
