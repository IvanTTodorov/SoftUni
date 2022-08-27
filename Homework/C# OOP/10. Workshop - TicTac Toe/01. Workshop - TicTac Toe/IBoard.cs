using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac_Toe
{
    public interface IBoard
    {
        bool IsFull();

        void PlaceSymbol(Index index, Symbol symbol);

        List<Index> GetEmptyPositions();

        Symbol GetRowSymbol(int row);
        Symbol GetColumnSymbol(int col);

        Symbol GetDiagonalTRBLSymbol();
        Symbol GetDiagonalTLBRSymbol();



    }
}
