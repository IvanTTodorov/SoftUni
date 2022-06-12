using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99._HashSet
{
   public class StringHashSet
    {
        private string[] array; 
        public StringHashSet(int capacity = 8)
        {
            array = new string[capacity];
        }
        public void Add (string key)
        {
            array[HashFunction(key)] = key;
        }
        private int HashFunction (string key)
        {
            int asciiResult = key[0] << 5 & key[key.Length - 1] >> 4;
            return asciiResult % array.Length;
        }
        public bool Contains (string key)
        {
            if(array[HashFunction(key)] == key)
            {
                return true; 
            }
            return false; 
        }
    }
}
