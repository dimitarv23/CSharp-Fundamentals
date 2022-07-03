using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int positionOfCupid = 0;
            int celebratingVDay = 0;

            string command = Console.ReadLine();
            while (command != "Love!")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int jumpLength = int.Parse(cmdArgs[1]);
                
                positionOfCupid = positionOfCupid + jumpLength >= houses.Count ? 0 : positionOfCupid + jumpLength;
                houses[positionOfCupid] -= 2;

                if (houses[positionOfCupid] == 0)
                {
                    Console.WriteLine($"Place {positionOfCupid} has Valentine's day.");
                    celebratingVDay++;
                }
                else if (houses[positionOfCupid] < 0)
                {
                    Console.WriteLine($"Place {positionOfCupid} already had Valentine's day.");
                    houses[positionOfCupid] = 0;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {positionOfCupid}.");

            if (celebratingVDay == houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houses.Count - celebratingVDay} places.");
            }
        }
    }
}
