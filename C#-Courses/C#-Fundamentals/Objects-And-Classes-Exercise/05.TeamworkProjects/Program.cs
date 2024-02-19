using System;
using System.Collections.Generic;

namespace _05.TeamworkProjects
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] usserAndTeams = Console.ReadLine().Split("-");

                Team currentTeam = new Team();
                teams.Add(currentTeam);
                foreach (var item in teams)
                {
                    if (!(item.TeamName == usserAndTeams[1] || item.Creator == usserAndTeams[0]))
                    {
                        currentTeam.TeamName = usserAndTeams[1];
                        currentTeam.Creator = usserAndTeams[0];
                        Console.WriteLine($"Team {currentTeam.TeamName} has been created by {currentTeam.Creator}!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Team {usserAndTeams[1]} was already created!");
                        break;
                    }

                }

            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] commandArgs = command.Split("->");

                command = Console.ReadLine();
            }
        }
    }
}
