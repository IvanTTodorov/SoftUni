using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FasterQueue
{
    public class FastQueue<T> : IAbstractQueue<T>
    {
        private Node<T> _head;
        private Node<T> tail; 
        public int Count {get; private set;}

        public bool Contains(T item)
        {
            var node = _head;
            while (node != null)
            {
                if(node.Equals(item))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public T Dequeue()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException(); 
            }
            var oldHead = _head;
            _head = _head.Next;
            this.Count--; 

            return oldHead.Item; 
        }

        public void Enqueue(T item)
        {
            var newNode = new Node<T>(item, null); 

            if(Count == 0)
            {
                this._head = this.tail = newNode;
                this.Count++;
                return; 
            }
            this.tail.Next = newNode;
            this.tail = tail.Next;
            Count++; 
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return this._head.Item;
            

        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = this._head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
       => this.GetEnumerator();
    }
}
