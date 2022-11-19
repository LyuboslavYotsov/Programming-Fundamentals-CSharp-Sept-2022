using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace P04StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^[^\@|\-|\!|\:\>]*\@(?<planet>[A-Za-z]+)[^\@|\-|\!|\:\>]*:(?<population>\d+)[^\@|\-|\!|\:\>]*\!(?<attackType>[A|D])\![^\@|\-|\!|\:\>]*\-\>(?<soldierCount>\d+)[^\@|\-|\!|\:\>]*$";
            Regex regex = new Regex(pattern);
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string cryptedMessage = Console.ReadLine();
                string decryptedMessage = Decrypt(cryptedMessage);
                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string Decrypt (string cryptedMessage)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (char ch in cryptedMessage.ToLower())
            {
                if (ch == 's' || ch == 't' | ch == 'a' | ch == 'r')
                {
                    count++;
                }
            }
            foreach (char ch in cryptedMessage)
            {
                char decryptedCh = (char)(ch - count);
                sb.Append(decryptedCh);
            }
            string decryptedMessage = sb.ToString();
            return decryptedMessage;
        }
    }
}
