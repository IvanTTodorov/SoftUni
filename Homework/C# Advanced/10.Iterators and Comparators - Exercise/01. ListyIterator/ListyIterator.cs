using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> 
    {
        private List<T> array;
        private int index;

        public ListyIterator(params T[] data)
        {
            array = new List<T>(data);
            index = 0; 
        }
        public bool HasNext()
        {
            return index + 1 < array.Count;
        }
        public bool Move()
        {
           
            if(HasNext())
            {
                index++;
                return true; 
            }
            else
            {
                return false;
            }
        }
        public void Print ()
        {
            if (array.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
