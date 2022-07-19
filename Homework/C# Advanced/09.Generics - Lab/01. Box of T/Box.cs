using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;
        public int Count => this.list.Count;

        public Box()
        {
            this.list = new List<T>();
        }
        public void Add (T element)
        {
            this.list.Add(element);
        }   

        public T Remove ()
        {
            T element = this.list.Last();
            list.RemoveAt(this.list.Count - 1);
            return element;
        } 


    }
}
