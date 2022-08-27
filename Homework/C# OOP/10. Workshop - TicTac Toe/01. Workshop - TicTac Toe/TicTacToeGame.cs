using TicTac_Toe.Players;
using System;
using System.Collections.Generic;
using System.Text;
using TicTac_Toe.Players;

namespace TicTac_Toe
{
    public class TicTacToeGame
    {

        public TicTacToeGame(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public IPlayer FirstPlayer { get; }
        public IPlayer SecondPlayer { get; }

        public Symbol Play()
        {
            Board board = new Board();

            IPlayer currentPlayer = FirstPlayer;
            Symbol symbol = Symbol.X;
            while (!IsGameOver(board))
            {
                var move = currentPlayer.Play(board);
                board.PlaceSymbol(move, symbol);

                if (currentPlayer == FirstPlayer)
                {
                    currentPlayer = SecondPlayer;
                    symbol = Symbol.O;
                }
                else
                {
                    currentPlayer = FirstPlayer;
                    symbol = Symbol.X;
                }
            }
            var winner = GetWinner(board);
            return winner;
        }
         


        private Symbol GetWinner(Board board)
        {
            for (int row = 0; row < board.Rows; row++)
            {
                var winner = board.GetRowSymbol(row);

                if (winner != Symbol.Empty)
                {
                    return winner;
                }
            }

            for (int col = 0; col < board.Cols; col++)
            {
                var winner = board.GetColumnSymbol(col); 

                if (winner != Symbol.Empty)
                {
                    return winner;
                }
            }

            if (board.GetDiagonalTLBRSymbol() != Symbol.Empty)
            { 
                var winner = board.GetDiagonalTLBRSymbol(); 
                if(winner != Symbol.Empty)
                {
                    return winner; 
                }
             }

            if (board.GetDiagonalTRBLSymbol() != Symbol.Empty)
            {
                var winner = board.GetDiagonalTRBLSymbol();
                if(winner != Symbol.Empty)
                {
                    return winner; 
                }
            }

            return Symbol.Empty;
        }

        private bool IsGameOver(Board board)
        {

            for (int row = 0; row < board.Rows; row++)
            {
                if (board.GetRowSymbol(row) != Symbol.Empty)
                {
                    return true;
                }
            }

            for (int col = 0; col < board.Cols; col++)
            {
                if (board.GetColumnSymbol(col) != Symbol.Empty)
                {
                    return true;
                }
            }

            if (board.GetDiagonalTLBRSymbol() != Symbol.Empty)
            {
                return true;
            }

            if (board.GetDiagonalTRBLSymbol() != Symbol.Empty)
            {
                return true;
            }

            return board.IsFull();

        }
    }


}

