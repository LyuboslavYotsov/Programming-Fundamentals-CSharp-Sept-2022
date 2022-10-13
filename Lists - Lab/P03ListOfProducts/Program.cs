using System;
using System.Linq;
using System.Collections.Generic;

namespace P03ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsNum = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < productsNum; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
