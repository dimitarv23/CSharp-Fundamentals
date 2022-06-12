using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> participants = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] cmdArgs = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = cmdArgs[0];
                string contestName = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                //Keep track of the individual statistics for each participant
                if (!participants.ContainsKey(username))
                {
                    participants.Add(username, 0);
                }

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName].ContainsKey(username))
                    {
                        participants[username] -= contests[contestName][username];

                        contests[contestName][username] = Math.Max(contests[contestName][username], points);

                        participants[username] += contests[contestName][username];
                    }
                    else
                    {
                        contests[contestName].Add(username, points);
                        participants[username] += points;
                    }
                }
                else
                {
                    contests.Add(contestName, new Dictionary<string, int>()
                    {
                        [username] = points
                    });
                    participants[username] += points;
                }

                input = Console.ReadLine();
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int counterParticipants = 1;

                foreach (var participant in contest.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{counterParticipants++}. {participant.Key} <::> {participant.Value}");
                }
            }

            Console.WriteLine("Individual standings: ");
            int counterIndividual = 1;

            foreach (var participant in participants
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key))
            {
                Console.WriteLine($"{counterIndividual++}. {participant.Key} -> {participant.Value}");
            }
        }
    }
}
