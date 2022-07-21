using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string elementToBeCompared = Console.ReadLine();

            int result = box.ReturnCountOfGreaterElements(elementToBeCompared);


            Console.WriteLine(result);
        }
    }
}
