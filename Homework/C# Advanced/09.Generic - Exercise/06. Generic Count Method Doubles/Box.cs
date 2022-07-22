using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> boxes;

        public Box()
        {
            boxes = new List<T>();
        }
        public void Add(T box)
        {
            boxes.Add(box);
        }

        public int ReturnCountOfGreaterElements(T element)
        {
            int count = 0;
            foreach (var item in boxes)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }


    }
}
