using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBaseHero> allHeroes = new List<IBaseHero>();
            int n = int.Parse(Console.ReadLine());

            while(allHeroes.Count < n)  
            { 
                string name = Console.ReadLine();
                string type = Console.ReadLine(); 


                if (type == "Paladin")
                {
                    IBaseHero paladin = new Paladin(name);
                    allHeroes.Add(paladin);
                    Console.WriteLine(paladin.CastAbility());
                } 
                else if (type == "Druid")
                {
                    IBaseHero druid = new Druid(name);
                    allHeroes.Add(druid);
                    Console.WriteLine(druid.CastAbility());    
                } 
                else if (type == "Rogue")
                {
                    IBaseHero rogue = new Rogue(name);
                    allHeroes.Add(rogue);
                    Console.WriteLine(rogue.CastAbility());
                } 
                else if (type == "Warrior")
                {
                    IBaseHero warrior = new Warrior(name);
                    allHeroes.Add(warrior);
                    Console.WriteLine(warrior.CastAbility());
                } 
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
            }

            int sum = 0;
            int bossPower = int.Parse(Console.ReadLine());
            sum = allHeroes.Sum(x => x.Power);

            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            } 
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
