using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set  
            {  
                if(value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }  
                    age = value; 
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }


        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay() => Age switch
        {
            int x when x >= 0 && x < 4 => 1.5,
            int x when x > 3 && x < 8 => 2,
            int x when x > 7 && x < 12 => 1,
            _ => 0.75
        };
            
        }
    }

