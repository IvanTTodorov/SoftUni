using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public CustomStack()
        {
            collection = new List<T>();

        }
        public void Push(T item)
        {
            collection.Add(item);
        }
        public void Pop()
        {
            if (collection.Count > 0)
            {
                collection.RemoveAt(collection.Count - 1);
            } 
            else
            {
                Console.WriteLine("No elements");
            }
        } 


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
