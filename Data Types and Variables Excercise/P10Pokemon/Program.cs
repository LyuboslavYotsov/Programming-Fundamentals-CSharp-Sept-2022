using System;

namespace P10Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong power = ulong.Parse(Console.ReadLine());
            uint pokeCunsume = uint.Parse(Console.ReadLine());
            uint exhoustion = uint.Parse(Console.ReadLine());
            int pokeCount = 0;
            decimal exhoustLine = (decimal)power / 2;

            while (power >= pokeCunsume)
            {
                pokeCount++;
                power -= pokeCunsume;
                if (power == exhoustLine && exhoustion != 0)
                {
                    power /= exhoustion;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
            




        }
    }
}
