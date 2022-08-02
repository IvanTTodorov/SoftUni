using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Milliters { get; set; }
        public Beverage(string name, decimal price, double milliters) 
            : base(name,price)
        {
           
        } 
    }
}
