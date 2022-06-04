using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.TeamworkProjects
{
    class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
            //Members.Add(this.Creator);
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int numberOfTeams = int.Parse(Console.ReadLine());

            //Create all the new teams
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] creatorInfo = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = creatorInfo[0];
                string teamName = creatorInfo[1];

                if (teams.Exists(team => team.Name == teamName))
                {
                    //If there's already a team with this name => throw a message
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Exists(team => team.Creator == creator))
                {
                    //If there's another team created by this user => throw a message
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    //If there's no team with such name or creator
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] memberInfo = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = memberInfo[0];
                string teamName = memberInfo[1];

                if (!teams.Exists(team => team.Name == teamName))
                {
                    //If the team the user tries to join does not exist => throw a message
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Exists(team => team.Members.Contains(member) || team.Creator == member))
                {
                    //If the user is already a member of another team => throw a message
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    //The user is not a member of another team and the team name is valid
                    int indexOfTeam = teams.FindIndex(team => team.Name == teamName);

                    //Add the member to the list of members of the team and break the loop
                    teams[indexOfTeam].Members.Add(member);
                }

                input = Console.ReadLine();
            }

            //Create two new sorted lists
            List<Team> disbandedTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(team => team.Name)
                .ToList();

            List<Team> sortedTeams = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.Name)
                .ToList();

            foreach (Team team in sortedTeams)
            {
                //Print all the valid teams info
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();

                for (int i = 0; i < team.Members.Count; i++)
                {
                    Console.WriteLine($"-- {team.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandedTeams)
            {
                //Print the disbanded teams' names
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}
