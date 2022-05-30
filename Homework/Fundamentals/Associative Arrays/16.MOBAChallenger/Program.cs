using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Player> playerList = new List<Player>();
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] command = input.Split();
                if (command[1] == "->")
                {
                    command = input.Split();
                    string playerName = command[0];
                    string position = command[2];
                    int skills = int.Parse(command[4]);


                    if (!playerList.Any(x => x.PlayerName == playerName))
                    {
                        Player player = new Player();
                        player.PlayerName = playerName;
                        player.PositionAndSkills = new Dictionary<string, int>();
                        player.PositionAndSkills.Add(position, skills);
                        playerList.Add(player);
                    }
                    else
                    {
                        var currentPlayer = playerList.First(x => x.PlayerName == playerName);
                        if (!currentPlayer.PositionAndSkills.ContainsKey(position))
                        {
                            currentPlayer.PositionAndSkills.Add(position, skills);
                        }
                        else
                        {
                            if (currentPlayer.PositionAndSkills[position] < skills)
                            {
                                currentPlayer.PositionAndSkills[position] = skills;
                            }
                        }
                    }
                }

                else if (command[1] == "vs")
                {
                    command = input.Split(' ');
                    string firstPlayerName = command[0];
                    string secondPlayerName = command[2];

                    if (playerList.Any(x => x.PlayerName == firstPlayerName)) { 
                            var firstPlayer = playerList.First(x => x.PlayerName == firstPlayerName);
                        if (playerList.Any(x => x.PlayerName == secondPlayerName))
                        {
                            var secondPlayer = playerList.First(x => x.PlayerName == secondPlayerName);

                            foreach (var pair in firstPlayer.PositionAndSkills)
                            {
                                foreach (var pair2 in secondPlayer.PositionAndSkills)
                                {
                                    if (pair.Key == pair2.Key)
                                    {
                                        if (pair.Value > pair2.Value)
                                        {
                                            secondPlayer.PositionAndSkills.Remove(pair2.Key);
                                        }
                                        else if (pair.Value < pair2.Value)
                                        {
                                            firstPlayer.PositionAndSkills.Remove(pair.Key);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
                Print(playerList);
            
        }
        public class Player
        {
            public string PlayerName { get; set; }
            public Dictionary<string, int> PositionAndSkills { get; set; }
        }

        public static void Print(List<Player> playerList)
        {
            var sortedListOfPlayers = playerList.OrderByDescending(x => x.PositionAndSkills.Values.Sum()).ThenBy(x => x.PlayerName)
                .ToList();

            foreach (var item in sortedListOfPlayers)
            {
                if (item.PositionAndSkills.Values.Sum() == 0)
                {
                    break;
                }
                Console.WriteLine($"{item.PlayerName}: {item.PositionAndSkills.Values.Sum()} skill");
                foreach (var pair in item.PositionAndSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}