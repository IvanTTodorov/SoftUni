using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            EqualityScale<int> equalityScale = new EqualityScale<int>(10,5);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}