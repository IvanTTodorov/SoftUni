using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTac_Toe.Players
{
    public class ConsolePlayer : IPlayer
    {

        public Index Play(Board board)
        {
            Console.WriteLine(board.ToString());
            Index position;
            while (true)
            {
                Console.WriteLine("Please, enter position (0, 0): ");
                 
                string input = Console.ReadLine(); 
                try
                {
                    position = new Index(input);
                }
                catch
                {
                    Console.WriteLine("Invalid position format!");
                    continue;
                    
                }
                if (!board.GetEmptyPositions().Any(x => x.Equals(position)))
                {
                    Console.WriteLine("This position is not available!");
                    continue; 
                }
                break;

            }
            return position; 
        }
    }
}
