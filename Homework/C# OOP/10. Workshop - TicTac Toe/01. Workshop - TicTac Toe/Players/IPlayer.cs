using System;
using System.Collections.Generic;
using System.Text;
using TicTac_Toe;

namespace TicTac_Toe.Players
{
    public interface IPlayer
    {
        Index Play(Board board);
    }
}
