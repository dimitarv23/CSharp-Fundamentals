using System;
using System.Collections.Generic;

namespace P03.Songs
{
    class Song
    {
        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] currSongInfo = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = currSongInfo[0];
                string name = currSongInfo[1];
                string time = currSongInfo[2];

                Song currentSong = new Song(typeList, name, time);
                songs.Add(currentSong);
            }

            string typeListToGetFrom = Console.ReadLine();

            if (typeListToGetFrom == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeListToGetFrom)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
