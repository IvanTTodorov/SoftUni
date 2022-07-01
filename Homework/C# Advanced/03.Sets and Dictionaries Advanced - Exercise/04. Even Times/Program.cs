using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int, int> numbersDict = new Dictionary<int, int>();
        
 
        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine()); 
           
            if(!numbersDict.ContainsKey(numbers))
                {
                    numbersDict.Add(numbers, 1);
                } 
                else
                {
                    numbersDict[numbers]++; 
                }                       
            } 
          
        foreach (var i in numbersDict)
        {
            if (i.Value % 2 == 0)
            {
                Console.WriteLine(i.Key);
            }
        }
    }
}