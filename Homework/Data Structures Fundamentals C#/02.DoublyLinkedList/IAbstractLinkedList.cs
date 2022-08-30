using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public interface IAbstractLinkedList<T> :IEnumerable<T>
    {
        int Count { get;  }
        void AddFirst(T item);
        T RemoveFirst();
        T GetFirst(); 
        void AddLast(T item);
        T RemoveLast();
        T GetLast(); 
    }
}
