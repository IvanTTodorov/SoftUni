using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.RemoveRandomElement();
            list.RemoveRandomElement();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
           
        }
    }
}