using System;

namespace P01BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int aditionalbonus = int.Parse(Console.ReadLine());

            decimal maxBonus = 0;
            int bestStudent = 0;

            for (int i = 1; i <= students; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                decimal currentBonus = (decimal)attendance / lectures * (5m + aditionalbonus);
                if (i == 1)
                {
                    maxBonus = currentBonus;
                    bestStudent = attendance;
                }

                if (currentBonus > maxBonus && i != 1)
                {
                    maxBonus = currentBonus;
                    bestStudent = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
