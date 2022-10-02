using System;
using System.Linq;

namespace P02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrThree = new string [Math.Min(arrTwo.Length, arrOne.Length)];
            int commonCount = 0;
            for (int i1 = 0; i1 < arrTwo.Length; i1++)
            {
                
                for (int i2 = 0; i2 < arrOne.Length; i2++)
                {
                    bool isCommon = true;
                    if (arrOne[i2] != arrTwo[i1])
                    {
                        isCommon = false;
                    }
                    if (isCommon)
                    {
                        arrThree[commonCount] = arrTwo[i1];
                        commonCount++;
                    }
                }
               
            }
            Console.WriteLine(string.Join(" ", arrThree));
        }
    }
}
