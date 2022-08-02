using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private int age;
        public string Name { get; set; }
        public int Age { get; set; }
       
        public string Gender { get; set; }


        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;    
        }

        public virtual string ProduceSound()
        {
            return " ";
        }
    }
}
