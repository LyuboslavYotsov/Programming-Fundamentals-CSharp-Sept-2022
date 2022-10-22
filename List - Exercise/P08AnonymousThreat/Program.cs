using System;
using System.Collections.Generic;
using System.Linq;

namespace P08AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commArgs[0];
                

                if (command == "merge")
                {
                    MergeWords(words, commArgs);
                }

                else if (command == "divide")
                {
                    DivideWords(words, commArgs);

                }


            }
            Console.WriteLine(string.Join(" ", words));
        }

        private static void DivideWords(List<string> words, string[] commArgs)
        {
            int index = int.Parse(commArgs[1]);
            int partitions = int.Parse(commArgs[2]);

            string word = words[index];
            int substringLenght = word.Length / partitions;
            int lastSubstringLenght = substringLenght + word.Length % partitions;

            List<string> partitionsList = new List<string>();

            for (int i = 0; i <= partitions - 1; i++)
            {
                int desieredLenght = substringLenght;
                if (i == partitions - 1)
                {
                    desieredLenght = lastSubstringLenght;
                }
                char[] newPartitionArr = word
                    .Skip(i * substringLenght)
                    .Take(desieredLenght)
                    .ToArray();
                string newPartition = string.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }
            words.RemoveAt(index);
            words.InsertRange(index, partitionsList);
        }

        private static void MergeWords(List<string> words, string[] commArgs)
        {
            int startIndex = int.Parse(commArgs[1]);
            int endIndex = int.Parse(commArgs[2]);
            string mergedString = string.Empty;

            if (startIndex < 0 || startIndex >= words.Count)
            {
                startIndex = 0;
            }
            if (endIndex >= words.Count || endIndex < 0)
            {
                endIndex = words.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergedString += currWord;
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, mergedString);
        }
    }
}
