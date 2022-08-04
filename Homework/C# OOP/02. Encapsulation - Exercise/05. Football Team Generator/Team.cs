using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Team
    {
        public Team(string teamName)
        {
            TeamName = teamName;
            Players = new List<Player>();
        }

        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

       public void AddPlayer (Player player)
        {
            Players.Add(player);
        } 
        public void RemovePlayer(string playerName)
        {
            Player currentPlayer = Players.FirstOrDefault(x => x.Name == playerName); 

            if(currentPlayer == null)
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.TeamName} team.");
            }
                Players.Remove(currentPlayer);
            
        }

        public int Raiting => Players.Count == 0 ? 0 :  
            (int)Math.Round(Players.Average(x => x.skillLevelOfThePlayer));
    }
}
