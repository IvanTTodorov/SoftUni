using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProjects = int.Parse(Console.ReadLine());
            List<Teams> newTeams = new List<Teams>();
            for (int i = 0; i < numberOfProjects; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                string creator = input[0];
                string team = input[1];

                if (newTeams.Any(x => x.Creator == creator)) {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                } 
                if (newTeams.Any(x => x.Team == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }

                Teams teams = new Teams();
                teams.Creator = creator;
                teams.Team = team;
                teams.Members = new List<string>();
                newTeams.Add(teams);

                Console.WriteLine($"Team {teams.Team} has been created by {teams.Creator}!");


            }

            string empty = string.Empty;
            while ((empty = Console.ReadLine()) != "end of assignment")
            {
                string[] text = empty.Split("->").ToArray();
                string currentUser = text[0];
                string currentTeam = text[1];

                if (!newTeams.Any(x => x.Team == currentTeam))
                {
                    Console.WriteLine($"Team {currentTeam} does not exist!");
                    continue;
                }
                if (newTeams.Any(x => x.Members.Contains(currentUser)) || (newTeams.Any(x => x.Creator == currentUser && x.Team == currentTeam)))
                {
                    Console.WriteLine($"Member {currentUser} cannot join team {currentTeam}!");
                    continue;
                }

                int index = newTeams.FindIndex(x => x.Team == currentTeam);
                newTeams[index].Members.Add(currentUser); 
                
   
            }
            List<Teams> validTeams = newTeams.FindAll(x => x.Members.Count > 0) 
                .OrderByDescending(x => x.Members.Count) 
                .ThenBy(x=>x.Team)   
                .ToList(); 

            List<Teams> invalidTeams = newTeams.FindAll(x => x.Members.Count == 0).OrderBy(x => x.Team).ToList();

            foreach (Teams teams in validTeams)
            {
                Console.WriteLine($"{teams.Team}");
                Console.WriteLine($"- {teams.Creator}");
                teams.Members.Sort();

                foreach (var member in teams.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
                


            Console.WriteLine("Teams to disband:");
            foreach (var teams in invalidTeams)
            {
                Console.WriteLine(teams.Team);
            }
            
        }
    }
    public class Teams
    {
        public string Creator { get; set; }
        public string Team { get; set; }

        public List<string> Members;
         
        
        
    }

}