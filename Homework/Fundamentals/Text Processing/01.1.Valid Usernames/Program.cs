using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validName = new List<string>();

            for (int i = 0; i < names.Length; i++)
            { 
                string currentName = names[i];   


                if (names[i].Length >= 3 && names[i].Length <= 16)
                {
                    bool isValid = true;

                    for (int j = 0; j < currentName.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currentName[j]) || currentName[j] == '-' || currentName[j] == '_'))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validName.Add(names[i]);
                    }
                    
                    }
                }
            foreach (var item in validName)
            {
                Console.WriteLine(item);
            }
            
            }
        }
    }
