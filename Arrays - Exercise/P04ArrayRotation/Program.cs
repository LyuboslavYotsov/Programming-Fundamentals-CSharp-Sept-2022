using System;
using System.Linq;

namespace P04ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            long rotationsCount = long.Parse(Console.ReadLine());
            long timesToRotatw = rotationsCount % arr.Length;

            
            for (int r = 1; r <= timesToRotatw; r++)
            {
                int firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
