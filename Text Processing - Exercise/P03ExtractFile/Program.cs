using System;

namespace P03ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");
            string[] nameAndExt = input[input.Length - 1].Split(".");
            string fileName = nameAndExt[0];
            string ext = nameAndExt[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
