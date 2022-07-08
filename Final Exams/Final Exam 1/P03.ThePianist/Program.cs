using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.ThePianist
{
    class Song
    {
        public Song(string name, string comp, string key)
        {
            this.SongName = name;
            this.Composer = comp;
            this.Key = key;
        }

        public string SongName;
        public string Composer;
        public string Key;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string songName = songInfo[0];
                string composer = songInfo[1];
                string key = songInfo[2];

                Song currSong = new Song(songName, composer, key);
                songs.Add(currSong);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] cmdArgs = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Add")
                {
                    string songToAdd = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];
                    AddSong(songs, songToAdd, composer, key);
                }
                else if (action == "Remove")
                {
                    string songToRemove = cmdArgs[1];
                    RemoveSong(songs, songToRemove);
                }
                else if (action == "ChangeKey")
                {
                    string song = cmdArgs[1];
                    string newKey = cmdArgs[2];
                    ChangeSongKey(songs, song, newKey);
                }

                command = Console.ReadLine();
            }

            foreach (var song in songs)
            {
                Console.WriteLine($"{song.SongName} -> Composer: {song.Composer}, Key: {song.Key}");
            }
        }

        static void AddSong(List<Song> songs, string song, string composer, string key)
        {
            if (songs.Any(s => s.SongName == song))
            {
                Console.WriteLine($"{song} is already in the collection!");
            }
            else
            {
                Song newSong = new Song(song, composer, key);
                songs.Add(newSong);
                Console.WriteLine($"{song} by {composer} in {key} added to the collection!");
            }
        }

        static void RemoveSong(List<Song> songs, string song)
        {
            if (songs.Any(s => s.SongName == song))
            {
                int indexOfSongToRemove = songs.FindIndex(s => s.SongName == song);
                songs.RemoveAt(indexOfSongToRemove);
                Console.WriteLine($"Successfully removed {song}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {song} does not exist in the collection.");
            }
        }

        static void ChangeSongKey(List<Song> songs, string song, string newKey)
        {
            if (songs.Any(s => s.SongName == song))
            {
                int indexOfSong = songs.FindIndex(s => s.SongName == song);
                songs[indexOfSong].Key = newKey;
                Console.WriteLine($"Changed the key of {song} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {song} does not exist in the collection.");
            }
        }
    }
}
