using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class Threeuple <Item1,Item2,Item3>
    {
        public Item1 Left { get; set; }
        public Item2 Middle { get; set; }
        public Item3 Right { get; set; }

        public Threeuple(Item1 left, Item2 middle, Item3 right)
        {
            Left = left;
            Middle = middle;
            Right = right;
        }

        public string GetItems()
        {
            return $"{Left} -> {Middle} -> {Right}";
        }
    }
}
