using System;
using TicTac_Toe.Players;

namespace TicTac_Toe
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToeGame(new ConsolePlayer(),
                new ConsolePlayer());

            game.Play();

            Console.WriteLine("Game over!");
        }
    }
}
