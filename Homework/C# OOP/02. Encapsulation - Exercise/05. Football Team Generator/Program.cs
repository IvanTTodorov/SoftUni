using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] playerInfo = input.Split(";");

                string command = playerInfo[0];
                try
                {
                    if (command == "Team")
                    {
                        Team team = new Team(playerInfo[1]);
                        teams.Add(playerInfo[1], team);
                    }
                    else if (command == "Add")
                    {                    
                        string currentTeam = playerInfo[1];
                        Player player = new Player(playerInfo[2], int.Parse(playerInfo[3])
                            , int.Parse(playerInfo[4]), int.Parse(playerInfo[5]), int.Parse(playerInfo[6])
                            , int.Parse(playerInfo[7]));

                        if (teams.ContainsKey(currentTeam))
                        {
                            teams[currentTeam].AddPlayer(player);
                        } 
                        else
                        {
                            Console.WriteLine($"Team {currentTeam} does not exist.");
                            continue;
                        }


                    } 
                    else if (command == "Remove")
                    {
                        string currentTeam = playerInfo[1];
                        string playerName = playerInfo[2];
                        teams[currentTeam].RemovePlayer(playerName);

                    }

                    else if (command == "Rating")
                    {   
                        string currentTeam = playerInfo[1];
                        if (teams.ContainsKey(currentTeam)) 
                        {
                            Console.WriteLine($"{currentTeam} - {teams[currentTeam].Raiting}");
                        }
                        else  
                        {  
                            Console.WriteLine($"Team {currentTeam} does not exist.");
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

