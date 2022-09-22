using System;

namespace P12RefacotrSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCount; i++)

            {
                int sum = 0;

                int currentNum = i;

                while (currentNum > 0)

                {

                    sum += currentNum % 10;

                    currentNum /= 10;

                }

               bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }
    }
}
