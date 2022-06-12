using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string commands = Console.ReadLine();

            while (commands != "end of contests")
            {
                string[] cmdArgs = commands
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contestName = cmdArgs[0];
                string contestPassword = cmdArgs[1];

                contests.Add(contestName, contestPassword);
                commands = Console.ReadLine();
            }

            //<"username", Dictionary<"contestName", contestPoints>>
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] cmdArgs = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (candidates.ContainsKey(username))
                    {
                        //If the username has participated in any contest

                        if (candidates[username].ContainsKey(contest))
                        {
                            //If the given user has already competed in the given contest => update the points in the contest only if the new points are more than the old ones
                            candidates[username][contest] = Math.Max(candidates[username][contest], points);
                        }
                        else
                        {
                            //If the user hasn't competed in the given contest => add the contest and the points he gained from it
                            candidates[username].Add(contest, points);
                        }
                    }
                    else
                    {
                        candidates.Add(username, new Dictionary<string, int>()
                        {
                            [contest] = points
                        });
                    }
                }

                input = Console.ReadLine();
            }

            string bestCandidateName = string.Empty;
            int bestCandidatePoints = 0;

            foreach (var candidate in candidates)
            {
                //Sum all the points for each candidate
                //candidate.Value returns the nested dictionary and .Values.Sum() sums all the values in the nested dictionary
                int candidatePoints = candidate.Value.Values.Sum();

                if (candidatePoints > bestCandidatePoints)
                {
                    bestCandidateName = candidate.Key;
                    bestCandidatePoints = candidatePoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var candidate in candidates.OrderBy(c => c.Key))
            {
                //Order the candidates by their names alphabetically
                Console.WriteLine($"{candidate.Key}");

                foreach (var contest in candidate.Value.OrderByDescending(c => c.Value))
                {
                    //Order each candidate's contests by the points they have, descending
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
