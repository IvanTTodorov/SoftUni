using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string animal = String.Empty;
            List<Animal> allAnimals = new List<Animal>();

            while((animal = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2]; 

        
                if (animal == "Dog")
                {
                    Animal dog = new Dog(name, age, gender); 
                    allAnimals.Add(dog);
                } 
                else if (animal == "Cat")
                {
                    Animal cat = new Cat(name, age, gender);
                    allAnimals.Add(cat);
                } 
                else if (animal == "Frog")
                {
                    Animal frog = new Frog(name, age, gender);
                    allAnimals.Add(frog);
                } 
                else if (animal == "Kitten")
                {
                    Animal kitten = new Kitten(name, age);
                    allAnimals.Add(kitten);
                } 
                else if (animal == "Tomcat")
                {
                    Animal tomCat = new Tomcat(name, age);
                    allAnimals.Add(tomCat);
                }

            }
            foreach (var currentAnimal in allAnimals)
            {
                Console.WriteLine(currentAnimal.GetType().Name);
                Console.WriteLine($"{currentAnimal.Name} {currentAnimal.Age} {currentAnimal.Gender}");
                Console.WriteLine(currentAnimal.ProduceSound());
            }
 

        }
    }   
}