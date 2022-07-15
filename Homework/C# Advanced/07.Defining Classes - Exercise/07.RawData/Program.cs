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
            int n = int.Parse(Console.ReadLine());
            List <Car> newCarList = new List <Car>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string model = command[0];
                int speed = int.Parse(command[1]);
                int power = int.Parse(command[2]);
                int weight = int.Parse(command[3]);
                string type = command[4];
                
                Tires[] tires = new Tires[]
                {
                    new Tires (double.Parse(command[5]), int.Parse(command[6])),
                    new Tires (double.Parse(command[7]), int.Parse(command[8])),
                    new Tires (double.Parse(command[9]), int.Parse(command[10])),
                    new Tires (double.Parse(command[11]), int.Parse(command[12])),
                };
                Cargo cargo = new Cargo(type, weight);
                Engine engine = new Engine(speed, power);
                Car car = new Car(model, engine, cargo, tires);
                newCarList.Add(car); 
            }
            string input = Console.ReadLine();
            List<Car> printedCars = new List<Car>(); 
            if (input == "fragile")
            {
                printedCars = newCarList.Where(x => x.Cargo.Type == "fragile" && x.Tires
                .Any(t => t.Pressure < 1)).ToList();
            }
            else if (input == "flammable")
            {
                printedCars = newCarList.Where(x => x.Cargo.Type == "flammable" 
                && x.Engine.Power > 250).ToList();  
            }
            foreach (var car in printedCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}