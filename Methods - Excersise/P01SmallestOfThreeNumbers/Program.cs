using System;

namespace P01SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            BiggestOfThree(numOne, numTwo, numThree);
        }

        static void BiggestOfThree(int numOne, int numTwo, int numThree)
        {
            if (numOne <= numTwo && numOne <= numThree)
            {
                Console.WriteLine(numOne);
            }
            else if (numTwo <= numOne && numTwo <= numThree)
            {
                Console.WriteLine(numTwo);
            }
            else if (numThree <= numOne && numThree <= numTwo)
            {
                Console.WriteLine(numThree);
            }
            
        }
    }
}
