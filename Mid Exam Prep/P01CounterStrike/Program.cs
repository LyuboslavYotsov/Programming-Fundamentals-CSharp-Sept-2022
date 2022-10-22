using System;

namespace P01CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            string input;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);

                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }

                else
                {
                    energy -= distance;
                    wins ++;
                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }
            }

            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
