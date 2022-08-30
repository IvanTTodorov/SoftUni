using System;

namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doubledLinkedList = new DoubledLinkedList<string>();
            doubledLinkedList.AddFirst("Maria");
            doubledLinkedList.AddLast("Ivan");
            doubledLinkedList.RemoveFirst(); 

            foreach (var item in doubledLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
