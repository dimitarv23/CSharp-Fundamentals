using System;
using System.Linq;

namespace P02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagonsState = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool hasEmptySeats = false;

            for (int i = 0; i < wagonsState.Length; i++)
            {
                if (wagonsState[i] >= 4)
                {
                    continue;
                }

                int availableSeats = 4 - wagonsState[i];

                if (peopleWaiting - availableSeats >= 0)
                {
                    peopleWaiting -= availableSeats;
                }
                else
                {
                    availableSeats = peopleWaiting;
                    hasEmptySeats = true;
                    peopleWaiting = 0;
                }

                wagonsState[i] += availableSeats;
            }

            if (peopleWaiting == 0 && hasEmptySeats)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagonsState));
            }
            else if (peopleWaiting > 0 && !hasEmptySeats)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", wagonsState));
            }
            else if (peopleWaiting == 0 && !hasEmptySeats)
            {
                Console.WriteLine(string.Join(" ", wagonsState));
            }
        }
    }
}
