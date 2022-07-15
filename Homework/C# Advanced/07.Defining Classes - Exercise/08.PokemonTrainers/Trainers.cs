using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainers
    {
        public string Name { get; set; }
        public int NumOfBadgets { get; set; }
        public List <Pokemon> Pokemon { get; set; }
        public Trainers(string name, int numIfBadgets)
        {
            Name = name;
            NumOfBadgets = 0;
            Pokemon = new List<Pokemon>();
        
    }
    }
}
