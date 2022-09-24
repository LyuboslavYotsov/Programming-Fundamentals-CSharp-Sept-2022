using System;

namespace P07WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pours = int.Parse(Console.ReadLine());
            int waterInTank = 0;

            for (int i = 1; i <= pours; i++)
            {
                int pouringLitters = int.Parse(Console.ReadLine());

                if (pouringLitters + waterInTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterInTank += pouringLitters;
                }
            }
            Console.WriteLine(waterInTank);
        }
    }
}
