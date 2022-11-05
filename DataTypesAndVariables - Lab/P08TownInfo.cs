using System;

namespace P08TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            long townPopulation = long.Parse(Console.ReadLine());
            int townArea = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {townPopulation} and area {townArea} square km.");
        }
    }
}
