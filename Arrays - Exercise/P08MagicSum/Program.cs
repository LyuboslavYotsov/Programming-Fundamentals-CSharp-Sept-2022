using System;
using System.Linq;
namespace P08MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int arrayI = 0; arrayI < array.Length; arrayI++)
            {
                

                for (int nextI = arrayI + 1; nextI < array.LongLength; nextI++)
                {
                    int indexSum = 0;
                    indexSum += (array[arrayI] + array[nextI]);

                    if (magicSum == indexSum)
                    {
                        Console.WriteLine($"{array[arrayI]}" + " " + $"{array[nextI]}");
                    }
                }
                

                
            }
        }
    }
}
