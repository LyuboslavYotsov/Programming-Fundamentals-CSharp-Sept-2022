using System;

namespace P03Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;
            int additionsCourse = people % capacity;

            if (additionsCourse == 0)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses + 1);
            }


        }
    }
}
