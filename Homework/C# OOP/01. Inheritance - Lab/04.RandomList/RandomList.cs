using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();  
        }
        public string RandomString()
        { 
            int index = random.Next(0,Count);
            return this[index];
        } 
           
        public void RemoveRandomElement()
        {
            int index = random.Next(0, Count);
            RemoveAt(index);
        }
    }
}
