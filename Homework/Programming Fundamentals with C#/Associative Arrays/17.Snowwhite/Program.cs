using System;
using System.Linq;
using System.Collections.Generic;


namespace Snowwhite_withClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Dictionary <string, List<Dwarf>> colourAndDwarfList = new Dictionary <string, List <Dwarf>> ();
            while ((input = Console.ReadLine()) != "Once upon a time")
                {
                string [] inputArr = input.Split(" <:> ");
                string dwarfName = inputArr [0];
                string hatColour = inputArr [1];
                int physic = int.Parse(inputArr[2]);

                if(!colourAndDwarfList.ContainsKey(hatColour))
                {
                    Dwarf dwarf = new Dwarf(); 
                    dwarf.Name = dwarfName;
                    dwarf.HatColour = hatColour;
                    dwarf.Physic = physic; 
                    colourAndDwarfList[hatColour] = new List<Dwarf> ();
                    colourAndDwarfList[hatColour].Add(dwarf); 
                }
                else if(colourAndDwarfList.
                    ContainsKey(hatColour) && !colourAndDwarfList[hatColour].
                    Any(x=>x.Name == dwarfName))
                {
                    Dwarf dwarf = new Dwarf();
                    dwarf.Name = dwarfName;
                    dwarf.HatColour = hatColour;
                    dwarf.Physic = physic;
                    colourAndDwarfList[hatColour].Add(dwarf);
                }
                else if(colourAndDwarfList.
                    ContainsKey(hatColour) && colourAndDwarfList[hatColour].
                    Any(x => x.Name == dwarfName))
                {
                    var currentDwarf = colourAndDwarfList[hatColour].First(x => x.Name == dwarfName);
                    if(currentDwarf.Physic < physic)
                    {
                        currentDwarf.Physic = physic; 
                    }
                }
            }
            Dictionary <string, int> sortedDict = new Dictionary<string, int> ();
            foreach (var (hatColour, listOfDwarfs) in colourAndDwarfList.OrderByDescending(x => x.Value.Count))
            {
                foreach (var dwarf in listOfDwarfs)
                {
                    sortedDict.Add($"({hatColour}) {dwarf.Name} <-> ", dwarf.Physic);
                } 
            }
            foreach (var pair in sortedDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }



        public class Dwarf
        {
            public string HatColour { get; set; }
            public string Name { get; set; }
            public int Physic { get; set; }


        }
    }
}