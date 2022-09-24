using System;

namespace P09SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCount = 0;
            int totalYield = 0;

            while (yield >= 100)
            {
                dayCount++;
                totalYield += yield - 26;
                yield -= 10;

                if (yield < 100)
                {
                    totalYield -= 26;
                }

            }
            
            Console.WriteLine(dayCount);
            Console.WriteLine(totalYield);
        }
    }
}
