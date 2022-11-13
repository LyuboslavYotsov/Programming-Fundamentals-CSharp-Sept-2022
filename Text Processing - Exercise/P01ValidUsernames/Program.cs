using System;

namespace P01ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ");

            foreach (string name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isValid = true;

                    foreach (char currCh in name)
                    {
                        if (!(char.IsLetterOrDigit(currCh) || currCh == '-' || currCh == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
