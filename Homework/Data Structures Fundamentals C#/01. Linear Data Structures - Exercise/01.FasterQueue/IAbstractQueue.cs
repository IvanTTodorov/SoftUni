using System;
using System.Collections.Generic;
using System.Text;

namespace FasterQueue
{
    public interface IAbstractQueue<T> : IEnumerable<T>
    {
        int Count { get; }
        void Enqueue(T item);
        T Dequeue();
        T Peek();
        bool Contains(T item); 
    }
}
