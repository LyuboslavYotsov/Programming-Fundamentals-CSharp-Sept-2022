using System;
using System.Numerics;


namespace P11Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            BigInteger maxValue = BigInteger.MinusOne;
            int maxSnow = int.MinValue;
            int maxTime = int.MinValue;
            int maxQuality = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);

                if (snowBallValue > maxValue)
                {
                    maxValue = snowBallValue;
                    maxSnow = snowBallSnow;
                    maxTime = snowBallTime;
                    maxQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");

        }
    }
}
