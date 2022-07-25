using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            ListyIterator<string> listy = null;

            while (command[0] != "END")
            {
                if (command[0] == "Create")
                {
                    listy = new ListyIterator<string>(command.Skip(1).ToArray());
                }
                else if (command[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (command[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command[0] == "Print")
                {
                    listy.Print();
                } 
                else if (command[0] == "PrintAll")
                {
                    listy.PrintAll();
                }

                command = Console.ReadLine().Split();
            }

        }
    }
}