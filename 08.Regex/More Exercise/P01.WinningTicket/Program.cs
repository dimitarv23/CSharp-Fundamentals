using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace P01.WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string patternWinning = @"[@*]{6,}|[#*]{6,}|[$*]{6,}|[\^*]{6,}";

            foreach (var ticket in tickets)
            {
                string output = string.Empty;

                if (ticket.Length == 20)
                {
                    //Split the ticket into two halves with a length of 10
                    string firstHalf = ticket.Substring(0, ticket.Length / 2);
                    string secondHalf = ticket.Substring(ticket.Length / 2);

                    //Get only the winning symbols from both halves
                    string firstHalfSymbols = Regex.Match(firstHalf, patternWinning).Value;
                    string secondHalfSymbols = Regex.Match(secondHalf, patternWinning).Value;

                    if (firstHalfSymbols.Length >= 6 
                        && secondHalfSymbols.Length >= 6
                        && firstHalfSymbols[0] == secondHalfSymbols[0])
                    {
                        //The symbols in both halves are 6 or more and are of the same type ($ and $ or @ and @ and so on)
                        //minRepeats stores the minimum encounters of any winning symbol and the output stores the winning message
                        int minRepeats = Math.Min(firstHalfSymbols.Length, secondHalfSymbols.Length);
                        output = $"ticket \"{ticket}\" - {minRepeats}{firstHalfSymbols[0]}";

                        if (minRepeats == 10)
                        {
                            //if minRepeats is 10, then both halves have 10 winning symbols => it is a jackpot
                            output += " Jackpot!";
                        }
                    }
                    else
                    {
                        //One of the halves doesn't contain 6 or more winning symbols or the symbols aren't the same type
                        output = $"ticket \"{ticket}\" - no match";
                    }
                }
                else
                {
                    //The ticket isn't 20 characters long => it is invalid
                    output = "invalid ticket";
                }

                Console.WriteLine(output);
            }
        }
    }
}
