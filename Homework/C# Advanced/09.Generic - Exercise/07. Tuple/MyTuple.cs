using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class MyTuple <Item1, Item2>
    {
        public Item1 LeftItem { get; set; }
        public Item2 RightItem { get; set; }
        public MyTuple(Item1 left, Item2 right)
        {
            LeftItem = left;
            RightItem = right;
        }
        public string GetItems()
        {
            return $"{LeftItem} -> {RightItem}"; 
        }
    }
}
