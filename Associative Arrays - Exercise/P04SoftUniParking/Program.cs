using System;
using System.Collections.Generic;
namespace P04SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string plateNum = input[2];
                    if (!register.ContainsKey(name))
                    {
                        register.Add(name, plateNum);
                        Console.WriteLine($"{name} registered {plateNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNum}");
                    }
                }

                else if (command == "unregister")
                {
                    if (!register.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        register.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var user in register)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
