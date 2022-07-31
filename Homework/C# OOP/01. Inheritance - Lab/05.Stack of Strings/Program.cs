using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "ivan", "maria" };
            
            StackOfStrings myStack = new StackOfStrings();
         
            Console.WriteLine(myStack.IsEmpty()); 

            myStack.AddRandge(list);
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(String.Join(" ", myStack));
            Console.WriteLine(myStack.IsEmpty());
        }
    }
}