using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainers> allTrainers = new List<Trainers>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] pokemonInfo = input.Split(' ');
                string trainerName = pokemonInfo[0];
                string pokemonName = pokemonInfo[1];
                string element = pokemonInfo[2];
                int health = int.Parse(pokemonInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                if (!allTrainers.Any(x => x.Name == trainerName))
                {
                    Trainers trainer = new Trainers(trainerName, 0);
                    trainer.Pokemon.Add(pokemon);
                    allTrainers.Add(trainer);

                }
                else
                {
                    foreach (var trainer in allTrainers)
                    {
                        if (trainer.Name == trainerName)
                        {
                            trainer.Pokemon.Add(pokemon);
                        }
                    }
                }


            }
            string text = Console.ReadLine();
            while (text != "End")
            {
                foreach (var trainer in allTrainers)
                {
                        if (trainer.Pokemon.Any(x => x.Element == text))
                        {
                            trainer.NumOfBadgets++;
                        }
                        else
                        {
                            foreach (var pokemon1 in trainer.Pokemon)
                            {
                                pokemon1.Health -= 10;
                            }
                            trainer.Pokemon.RemoveAll(x => x.Health <= 0);
                        }
                    } 

                text = Console.ReadLine(); 
            }
            foreach (var trainer in allTrainers.OrderByDescending(x => x.NumOfBadgets))  
                {
                Console.WriteLine($"{trainer.Name} {trainer.NumOfBadgets} {trainer.Pokemon.Count}");
            }
            
        }
    }
}
