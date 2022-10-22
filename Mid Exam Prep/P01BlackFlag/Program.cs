using System;

namespace P01BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal dailyPlunder = decimal.Parse(Console.ReadLine());
            decimal plunderGoal = decimal.Parse(Console.ReadLine());

            decimal totalPlunder = 0m;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.50m;
                }

                if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.30m;
                }
            }

            if (totalPlunder >= plunderGoal)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                decimal insufficcient = (totalPlunder / plunderGoal) * 100.0m;
                Console.WriteLine($"Collected only {insufficcient:f2}% of the plunder.");
            }
        }
    }
}
