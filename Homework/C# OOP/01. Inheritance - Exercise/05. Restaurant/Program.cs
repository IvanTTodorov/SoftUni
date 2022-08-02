using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Restaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Product chocolateCake = new Cake("chocolateCake");
            Console.WriteLine(chocolateCake.Name);
            
        }
    }
}