using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTac_Toe.Players
{
    public class RandomPlayer : IPlayer
    {
        Random random;

        public RandomPlayer()
        {
            random = new Random();
        }
        public Index Play(Board board)
        {
            var availablePositions = board.GetEmptyPositions().ToList();
            return availablePositions[random.Next(0, availablePositions.Count)];
        }
    }
}
