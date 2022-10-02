using System;
using System.Linq;

namespace P07MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string longestSequence = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                string sequence = string.Empty;
                int move = 1;
                int firstWriting = 1;
                while (i + move < array.Length && array[i] == array[i + move])
                {
                    move++;
                    if (firstWriting == 1)
                    {
                        sequence += $"{array[i]}" + " " + $"{array[i + 1]}";
                        firstWriting++;
                    }
                    else
                    {
                        sequence += " " + $"{array[i]}";
                    }
                    
                }
                if (sequence.Length > longestSequence.Length)
                {
                    longestSequence = sequence;
                    
                }
                
            }
            Console.WriteLine(longestSequence);
        }
    }
}
