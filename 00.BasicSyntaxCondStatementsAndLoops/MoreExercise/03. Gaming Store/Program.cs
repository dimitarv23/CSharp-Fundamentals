using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            double gamePrice = 0;
            double totalSpent = 0;
            string gameName = Console.ReadLine();

            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    gameName = Console.ReadLine();
                    continue;
                }

                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= gamePrice;
                    Console.WriteLine($"Bought {gameName}");

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        Environment.Exit(0);
                    }
                    totalSpent += gamePrice;
                }

                gameName = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}