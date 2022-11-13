using System;
using System.Collections.Generic;
using System.Linq;
namespace P07StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> bombField = input
                .ToList();
            
            int bombPower = 0;

            for (int i = 0; i < bombField.Count; i++)
            {
                if (bombField[i] == '>')
                {
                    bombPower += int.Parse(bombField[i + 1].ToString());
                    bombField.RemoveAt(i + 1);
                    bombPower--; 
                }
                else if (bombField[i] != '>' && bombPower > 0)
                {
                    bombField.RemoveAt(i);
                    bombPower--;
                    i--;
                }
                
            }
            Console.WriteLine(String.Join("", bombField));
        }
    }
}
