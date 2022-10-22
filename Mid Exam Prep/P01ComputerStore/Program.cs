using System;

namespace P01ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal totalPrice = 0;
            decimal taxPrice = 0;
            
            while ((input = Console.ReadLine()) != "special" && input != "regular")
            {
                decimal currPrice = decimal.Parse(input);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                totalPrice += currPrice;
                taxPrice += currPrice * 0.2m;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal totalWithTax = totalPrice + taxPrice; 

            if (input == "special")
            {
                totalWithTax -= totalWithTax * 0.1m;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {taxPrice:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalWithTax:f2}$");
            
        }
    }
}
