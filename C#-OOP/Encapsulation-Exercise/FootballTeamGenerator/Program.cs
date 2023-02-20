using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>(); 
            Dictionary<string, Player> players = new Dictionary<string, Player>(); 

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split(';', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (input[0] == "Team")
                    {
                        if (!teams.ContainsKey(input[1]))
                        {
                            Team team = new Team(input[1]);
                            teams.Add(input[1], team);
                        }
                    }
                    else if (input[0] == "Add")
                    {
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        Player player = new Player(input[2], int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]),
                            int.Parse(input[6]), int.Parse(input[7]));

                        players.Add(input[2], player);

                        teams[input[1]].AddPlayer(player);
                    }
                    else if (input[0] == "Remove")
                    {
                        if (!players.ContainsKey(input[2]))
                        {
                            Console.WriteLine($"Player {input[2]} is not in {input[1]} team.");
                            command = Console.ReadLine();
                            continue;
                        }

                        players.Remove(input[2]);
                        teams[input[1]].RemovePlayer(input[2]);
                    }
                    else if (input[0] == "Rating")
                    {
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine($"{input[1]} - {teams[input[1]].Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
