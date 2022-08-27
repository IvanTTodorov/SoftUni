using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac_Toe
{
    public class Index 
    {
        public Index(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public Index(string str)
        {
            var positions = str.Split(", ");
            this.Row = int.Parse(positions[0]);
            this.Col = int.Parse(positions[1]); 
        }

        public int Row { get; set; }
        public int Col { get; set; }
        

        public override string ToString()
        {
            return $"{Row}, {Col}";
        }
        public override bool Equals(object obj)
        {
            var otherIndex = obj as Index;

            return Row == otherIndex.Row && Col == otherIndex.Col; 
        }
    }
}
