using System;
using System.Collections.Generic;
using System.Linq;

namespace P03Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songs = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();
            for (int i = 1; i <= songs; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input
                    .Split("_")
                    .ToArray();
                string type = inputArr[0];
                string name = inputArr[1];
                string time = inputArr[2];

                songsList.Add(new Song(type, name, time));
            }

            string list = Console.ReadLine();
            if (list == "all")
            {
                for (int i = 0; i < songsList.Count; i++)
                {
                    Song currSong = songsList[i];
                    Console.WriteLine(currSong.Name);
                }
            }
            else
            {
                for (int i = 0; i < songsList.Count; i++)
                {
                    Song currSong = songsList[i];
                    if (currSong.Type == list)
                    {
                        Console.WriteLine(currSong.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string type, string name, string time)
        {
            Type = type;
            Name = name;
            Time = time;
        }
    
        public string Type { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
