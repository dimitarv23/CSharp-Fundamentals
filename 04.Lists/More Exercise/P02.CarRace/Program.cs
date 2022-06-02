using System;
using System.Linq;

namespace P02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] track = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < track.Length / 2; i++)
            {
                leftRacerTime += track[i];
                rightRacerTime += track[track.Length - 1 - i];

                if (track[i] == 0)
                {
                    leftRacerTime *= 0.8;
                }
                if (track[track.Length - 1 - i] == 0)
                {
                    rightRacerTime *= 0.8;
                }
            }

            if (leftRacerTime <= rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
    }
}
