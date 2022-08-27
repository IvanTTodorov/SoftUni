using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac_Toe
{
    public class Board : IBoard
    {
        private Symbol[,] board;

        //ctors
        public Board()
            : this(3, 3)
        {

        }
        public Board(int rows, int cols)
        {

            if(rows != cols)
            {
                throw new ArgumentException("Rows should be equal to cols."); 
            }
            Rows = rows;
            Cols = cols;
            board = new Symbol[rows, cols];
        }

        //======================================================== 



        public int Rows { get; }
        public int Cols { get; }
        public Symbol[,] BoardState => board;

          


        //Check if player win the game 
        public Symbol GetRowSymbol(int row)
        {
            Symbol symbol = board[row, 0];
            if(symbol ==Symbol.Empty)
            {
                return Symbol.Empty;
            }

            for (int col = 0; col < this.Cols; col++)
            {
                if (this.board[row, col] != symbol)
                {
                    return Symbol.Empty; 
                }
            }
            return symbol;
        }

        public Symbol GetColumnSymbol(int col)
        {
            Symbol symbol = board[0, col]; 
            if(symbol == Symbol.Empty)
            {
                return Symbol.Empty;
            }

            for (int row = 0; row < Rows; row++)
            {
                if (this.board[row, col] != symbol)
                {
                    return Symbol.Empty; 
                }
            }
            return symbol; 
        }

        public Symbol GetDiagonalTLBRSymbol()
        {
            var symbol = board[0, 0];
            if(symbol == Symbol.Empty)
            {
                return Symbol.Empty;
            }

            for (int rows = 1; rows < Rows; rows++)
            {
                if (this.board[rows, rows] != symbol)
                {
                    return Symbol.Empty;
                }
            }
            return symbol; 
        }

        public Symbol GetDiagonalTRBLSymbol()
        {
            var symbol = board[0, Rows - 1];
            if (symbol == Symbol.Empty)
            {
                return Symbol.Empty;
            }

            for (int row = 1; row < Rows; row++)
            {
                if (this.board[row, row - Rows - 1] != symbol)
                {
                    return Symbol.Empty;
                }
            }
            return symbol;
        } 

        //============================================================= 

         


        public List<Index> GetEmptyPositions()
        {
            var positions = new List<Index>();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (board[i,j] == Symbol.Empty)
                    {
                        positions.Add(new Index(i, j));
                    }
                }
            }
            return positions; 
        }

        public bool IsFull()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (board[i,j] == Symbol.Empty)
                    {
                        return false;
                    }
                }
            }
            return true; 
        }

        public void PlaceSymbol(Index index, Symbol symbol)
        {
            if(index.Row < 0 || index.Col < 0
                || index.Row >= Rows || index.Col >= Cols)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            board[index.Row, index.Col] = symbol;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (board[i, j] == Symbol.Empty)
                    {
                        sb.Append('.'); 
                    }
                    else
                    {
                        sb.Append(board[i, j]); 
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString().Trim(); 

        }

    }
}
