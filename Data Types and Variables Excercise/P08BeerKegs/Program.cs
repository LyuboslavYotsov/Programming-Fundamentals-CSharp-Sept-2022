using System;
using System.Numerics;

namespace P08BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsNum = int.Parse(Console.ReadLine());
            string biggest = string.Empty;
            decimal biggestVolume = decimal.MinValue;

            for (int i = 1; i <= kegsNum; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                long height = long.Parse(Console.ReadLine());

                double kegVolume = (Math.PI * Math.Pow((double)radius, 2)) * height;

                if ((decimal)kegVolume > biggestVolume)
                {
                    biggest = model;
                    biggestVolume = (decimal)kegVolume;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
