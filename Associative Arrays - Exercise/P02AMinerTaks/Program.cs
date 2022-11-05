using System;
using System.Collections.Generic;
using System.Linq;
namespace P02AMinerTaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input;
            int tracker = 1;
            string resource = string.Empty;
            while ((input = Console.ReadLine()) != "stop")
            {
                
                if (tracker % 2 != 0)
                {
                    resource = input;
                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, 0);
                    }
                }
                else
                {
                    int value = int.Parse(input);
                    resources[resource] += value;
                }
                tracker++;
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
