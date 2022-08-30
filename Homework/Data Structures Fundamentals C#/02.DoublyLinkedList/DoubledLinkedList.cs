using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class DoubledLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var newNode = new Node<T>(item, null, null);

            if (Count == 0)
            {
                this.head = this.tail = newNode;
                Count++;
                return; 
            } 
            var oldHead = this.head;
            oldHead.Previous = newNode;
            this.head = newNode; 
            this.head.Next = oldHead;
            Count++; 
        }

        public void AddLast(T item)
        {
            var newNode = new Node<T>(item, null, null);
            if (Count == 0)
            {
                this.head = this.tail = newNode;
                Count++;
                return;
            }

            var oldTail = this.tail;
            oldTail.Next = newNode;
            this.tail = newNode;
            this.tail.Previous = oldTail;
            Count++; 
        }

        public T GetFirst()
        {
            ValidateCollection();
            return head.Item;
        }

        public T GetLast()
        {
            ValidateCollection();
            return tail.Item;
        }

        public T RemoveFirst()
        {
            var oldHead = head;
            head = head.Next;
            head.Previous = null; 
            this.Count--;

            return oldHead.Item;
        }

        public T RemoveLast()
        {
            ValidateCollection();
            var oldTail = tail;
            tail = tail.Previous;
            tail.Next = null; 
            this.Count--;

            return oldTail.Item; 
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = this.head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

        private void ValidateCollection()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(); 
            }
        }
    }
}
