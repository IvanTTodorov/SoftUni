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

            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double elementToBeCompared = double.Parse(Console.ReadLine());

            int result = box.ReturnCountOfGreaterElements(elementToBeCompared);


            Console.WriteLine(result);
        }
    }
}
