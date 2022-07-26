using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Lake : IEnumerable<int>
    {
        private int[] lake;

        public Lake(params int[] stones) 
        {
            lake = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {

            for (int i = 0; i < lake.Length; i++)
            {
                if( i % 2 == 0)
                {
                    yield return lake[i];
                }
            }
            for (int i = lake.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return lake[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}
