using System;

namespace P04PrintingTriangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }

        static void PrintTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintColums(i);
            }

            for (int i = input - 1; i >= 1; i--)
            {
                PrintColums(i);
            }
        }

        private static void PrintColums(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
