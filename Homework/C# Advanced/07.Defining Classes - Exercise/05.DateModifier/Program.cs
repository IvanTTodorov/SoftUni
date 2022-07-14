using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine(); 
            string dateTwo = Console.ReadLine();
            Console.WriteLine(DateModifier.Calculate(dateOne , dateTwo));

        }
    }
    public static class DateModifier
    {
        public static int Calculate (string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.Parse(dateOne);
            DateTime secondDate = DateTime.Parse(dateTwo); 

            int calculator = Math.Abs((firstDate - secondDate).Days);
            return calculator; 
        }
    }
}