using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {    
           
           Factorial number = new Factorial();
           
           number.n = int.Parse(Console.ReadLine());
         
            number.CalculateFactorial();
          
            
        }
    } 
    public class Factorial
    {
        public BigInteger n { get; set; } 
          
        public void CalculateFactorial()
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;  
            }
            Console.WriteLine(factorial);
        } 
    }
}