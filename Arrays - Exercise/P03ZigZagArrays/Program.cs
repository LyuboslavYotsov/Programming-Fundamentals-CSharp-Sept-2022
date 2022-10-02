using System;
using System.Linq;

namespace P03ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int rotation = 1;

            for (int i = 0; i < n; i++)
            {
                int[] arr3 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (rotation % 2 != 0)
                {
                    arr1[i] = arr3[0];
                    arr2[i] = arr3[1];
                }
                else
                {
                    arr2[i] = arr3[0];
                    arr1[i] = arr3[1];
                }
                rotation++;

            }
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item2 in arr2)
            {
                Console.Write(item2 + " ");
            }
        }
    }
}
