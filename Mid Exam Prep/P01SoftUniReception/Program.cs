using System;

namespace P01SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empOne = int.Parse(Console.ReadLine());
            int empTwo = int.Parse(Console.ReadLine());
            int empThree = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());
            int time = 0;

            while (studentsCount > 0)
            {
                time++;
                if (time % 4 == 0)
                {
                    continue;
                }

                studentsCount -= empOne + empTwo + empThree;

            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
