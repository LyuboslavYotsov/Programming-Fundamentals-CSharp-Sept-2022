using System;
using System.Linq;

namespace P04ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] charsArr = Console.ReadLine()
            .Split()
            .ToArray();

            for (int i = charsArr.Length - 1; i >= 0; i--)
            {
                Console.Write(charsArr[i] + ' ');
            }
        }
    }
}
