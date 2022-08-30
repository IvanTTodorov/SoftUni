using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class Node<T>
    {

        public Node(T item, Node<T> next, Node<T> previous) 
        {
            Item = item; 
            Next = next;
            Previous = previous; 
        }
        public Node()
        {

        }

        public T Item { get; set; }
        public Node<T> Next { get; set; }
        public Node <T> Previous { get; set; }

    }
}
