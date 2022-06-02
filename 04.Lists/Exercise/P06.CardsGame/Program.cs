using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    int winningCard = firstPlayerCards[0];

                    firstPlayerCards.RemoveAt(0);

                    firstPlayerCards.Add(winningCard);
                    firstPlayerCards.Add(secondPlayerCards[0]);

                    secondPlayerCards.RemoveAt(0);
                }
                else if (secondPlayerCards[0] > firstPlayerCards[0])
                {
                    int winningCard = secondPlayerCards[0];

                    secondPlayerCards.RemoveAt(0);

                    secondPlayerCards.Add(winningCard);
                    secondPlayerCards.Add(firstPlayerCards[0]);

                    firstPlayerCards.RemoveAt(0);
                }
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            if (firstPlayerCards.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }

            if (secondPlayerCards.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
        }
    }
}
