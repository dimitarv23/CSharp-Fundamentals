using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players =
                new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                string[] cmdArgs = input
                    .Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Length == 3)
                {
                    //Input a player
                    string playerName = cmdArgs[0];
                    string playerPosition = cmdArgs[1];
                    int playerSkill = int.Parse(cmdArgs[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(playerPosition))
                        {
                            //Get the bigger skill from the newly given one and the older one
                            players[playerName][playerPosition] =
                                Math.Max(players[playerName][playerPosition], playerSkill);
                        }
                        else
                        {
                            //Add a new position to the player
                            players[playerName].Add(playerPosition, playerSkill);
                        }
                    }
                    else
                    {
                        //Add a new player with the given name and set the values of the position and skill
                        players.Add(playerName, new Dictionary<string, int>()
                        {
                            [playerPosition] = playerSkill
                        });
                    }
                }
                else if (cmdArgs.Length == 2)
                {
                    //Player vs player situation
                    string firstPlayer = cmdArgs[0];
                    string secondPlayer = cmdArgs[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        bool haveCommonPosition = false;
                        string playerToRemove = string.Empty;

                        foreach (var position in players[firstPlayer])
                        {
                            if (players[secondPlayer].ContainsKey(position.Key))
                            {
                                if (players[firstPlayer][position.Key]
                                    > players[secondPlayer][position.Key])
                                {
                                    playerToRemove = secondPlayer;
                                }
                                else if (players[firstPlayer][position.Key]
                                    < players[secondPlayer][position.Key])
                                {
                                    playerToRemove = firstPlayer;
                                }

                                haveCommonPosition = true;
                                break;
                            }
                        }

                        if (haveCommonPosition && playerToRemove != string.Empty)
                        {
                            players.Remove(playerToRemove);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(p => p.Key))
            {
                int totalSkill = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {totalSkill} skill");

                foreach (var playerInfo in player.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {playerInfo.Key} <::> {playerInfo.Value}");
                }
            }
        }
    }
}
