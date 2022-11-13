using System;
using System.Linq;
using System.Text;

namespace ME03TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder sb = new StringBuilder();
                int keyCount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (keyCount == key.Length)
                    {
                        keyCount = 0;
                    }

                    char currCh = input[i];
                    int currChPos = (int)currCh;
                    int decryptPos = currChPos - key[keyCount];
                    char newCh = (char)decryptPos;
                    sb.Append(newCh);
                    keyCount++;
                }
                string decryptedMessage = sb.ToString();

                int resourceStartIndex = decryptedMessage.IndexOf('&') + 1;
                int resourceEndIndex = decryptedMessage.LastIndexOf('&');
                string resourceType = decryptedMessage[resourceStartIndex..resourceEndIndex];

                int coordinatesStartIndex = decryptedMessage.IndexOf('<') + 1;
                int coordinatesEndIndex = decryptedMessage.IndexOf('>');
                string coordinates = decryptedMessage[coordinatesStartIndex..coordinatesEndIndex];

                Console.WriteLine($"Found {resourceType} at {coordinates}");
            }
        }
    }
}
