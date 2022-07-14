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
            Dictionary<string, Car> cars = new Dictionary<string, Car>(); 

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                
                if(!cars.ContainsKey(model))
                {
                    Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, 0);
                    cars.Add(model, car); 
                }
            }
            string text = Console.ReadLine(); 
            while(text != "End")
            {
                string[] input = text.Split();
                string carModel = input[1]; 
                double amountOfKm = double.Parse(input[2]);
                cars[carModel].Drive(amountOfKm); 

                text = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}