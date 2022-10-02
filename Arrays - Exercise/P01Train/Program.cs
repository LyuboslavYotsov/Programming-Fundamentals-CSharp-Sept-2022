

namespace P01Train
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int totalPassagers = 0;

            int[] passagers = new int[wagons];
            for (int i = 0; i < passagers.Length; i++)
            {
                passagers[i] = int.Parse(Console.ReadLine());
                totalPassagers += passagers[i];
                
            }
            foreach (var item in passagers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassagers) ;

        }
    }
}
