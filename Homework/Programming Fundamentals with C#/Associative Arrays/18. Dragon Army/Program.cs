using System;
using System.Linq;
using System.Collections.Generic;


namespace Snowwhite_withClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dragonsDict = new Dictionary<string, List<Dragons>>();
            int number = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < number; i++)
            {
                string[] dragonsInfo = Console.ReadLine().Split();
                string dragonColour = dragonsInfo[0]; 
                string dragonName = dragonsInfo[1];
                var damage = dragonsInfo[2] == "null" ? 45 : int.Parse(dragonsInfo[2]);
                var health = dragonsInfo[3] == "null" ? 250 : int.Parse(dragonsInfo[3]);
                var armor = dragonsInfo[4] == "null" ? 10 : int.Parse(dragonsInfo[4]);


                if (!dragonsDict.ContainsKey(dragonColour))
                {
                    Dragons dragon = new Dragons();
                    dragon.Name = dragonName;
                    dragon.Damage = damage; 
                    dragon.Health = health;
                    dragon.Armor = armor;
                    
                    dragonsDict[dragonColour] = new List<Dragons>();
                    dragonsDict[dragonColour].Add(dragon);
                } 
                  else if ((dragonsDict.ContainsKey(dragonColour) && !dragonsDict[dragonColour].Any(x => x.Name == dragonName)))
                {
                    Dragons dragon = new Dragons();
                    dragon.Name = dragonName;
                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                    dragonsDict[dragonColour].Add(dragon);
                }

                else if (dragonsDict.ContainsKey(dragonColour) && dragonsDict[dragonColour].Any(x=> x.Name == dragonName))
                {
                    var currentDragon = dragonsDict[dragonColour].First(x => x.Name == dragonName);
                    currentDragon.Name = dragonName;
                    currentDragon.Damage = damage;
                    currentDragon.Health = health; 
                    currentDragon.Armor = armor; 
                }
            }
             
            foreach(var (type, listOfDragons) in dragonsDict)
            {
                double Damage = listOfDragons.Sum(x=>x.Damage) / listOfDragons.Count;
                double Health = listOfDragons.Sum(x => x.Health) / listOfDragons.Count;
                double Armor = listOfDragons.Sum(x => x.Armor) / listOfDragons.Count;

                Console.WriteLine($"{type}::({Damage:f2}/{Health:f2}/{Armor:f2})");
                foreach (var dragon in listOfDragons.OrderBy(x => x.Name))
                {
                 
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}"); 

                }
            }

        }
    } 

    public class Dragons
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }
    }
}