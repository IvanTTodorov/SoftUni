using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Elf("ivan", 100);
            Console.WriteLine(hero);
        }
    }
}