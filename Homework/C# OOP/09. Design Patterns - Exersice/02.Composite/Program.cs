using System;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("IPhone", 1000);
            phone.CalculateTotalPrice();

            var rootBox = new CompositeGift("RootBox", 0);
            var truck = new SingleGift("Truck", 9);
            var car = new SingleGift("Car", 9);

            rootBox.Add(truck);
            rootBox.Add(car);

            Console.WriteLine($"Total price of this composite present is: " +
                $"{rootBox.CalculateTotalPrice()}");
        }
    }
}
