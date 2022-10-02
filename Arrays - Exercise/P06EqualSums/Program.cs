using System;
using System.Linq;

namespace P06EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool equal = false;
            int equalIndex = 0;

            for (int arrayI = 0; arrayI < numbers.Length; arrayI++)
            {
                int leftSum = 0;
                int rightSum = 0;
               
                if (arrayI - 1 >= 0)
                {
                    for (int leftI = arrayI - 1; leftI >= 0; leftI--)
                    {
                        leftSum += numbers[leftI];
                    }
                }
                if (arrayI + 1 <= numbers.Length - 1)
                {
                    for (int rightI = arrayI + 1; rightI < numbers.Length; rightI++)
                    {
                        rightSum += numbers[rightI];
                    }
                }

                if (leftSum == rightSum)
                {
                    equalIndex = arrayI;
                    equal = true;
                    break;
                }
                


            }

            if (equal)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
