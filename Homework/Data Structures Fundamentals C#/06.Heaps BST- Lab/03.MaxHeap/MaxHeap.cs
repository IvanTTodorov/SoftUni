namespace _03.MaxHeap
{
    using System;
    using System.Collections.Generic;

    public class MaxHeap<T> : IAbstractHeap<T> where T : IComparable<T>
    {
        private List<T> element;
        public MaxHeap()
        {
            this.element = new List<T>();
        }
        public int Size => this.element.Count;

        public void Add(T element)
        {
            this.element.Add(element);
            this.HeapifyUp(this.element.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            var parentIndex = (index - 1) / 2; 
            while(index > 0 && this.IsGreater(index, parentIndex))
            {
                this.Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private bool IsGreater(int index, int parentIndex)
        {
            return this.element[index].CompareTo(this.element[parentIndex]) > 0;
        }

        private void Swap(int index, int parentIndex)
        {
            var temp = this.element[index];
            this.element[index] = this.element[parentIndex];
            this.element[parentIndex] = temp;
        }

        public T ExtractMax()
        { 
            if(this.element.Count == 0)
            {
                throw new InvalidOperationException(); 
            }
            var element = this.element[0];
            this.Swap(0, this.element.Count - 1);

            this.element.RemoveAt(this.element.Count - 1);
            this.HeapifyDown(0);
            
            return element;

        }

        private void HeapifyDown(int index)
        {
            var biggerChildIndex = this.GetBiggerIndex(index);

            while (biggerChildIndex >= 0 && biggerChildIndex < this.element.Count && this.IsGreater(biggerChildIndex, index))
            {
                this.Swap(biggerChildIndex, index);

                index = biggerChildIndex;
                biggerChildIndex = this.GetBiggerIndex(index); 
            }
        }

        private int GetBiggerIndex(int index)
        {
            var firstChildIndex = index * 2 + 1; 
            var secondChildIndex = index * 2 + 2;

            if(secondChildIndex < this.element.Count)
            {
                if(this.IsGreater(firstChildIndex, secondChildIndex))
                {
                    return firstChildIndex;
                }
                return secondChildIndex;
            }
            else if(firstChildIndex < this.element.Count)
            {
                return firstChildIndex;
            }
            else
            {
                return -1;
            }
        }

        public T Peek()
        {  
            if(this.element.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return this.element[0]; 
        }
    }
}
