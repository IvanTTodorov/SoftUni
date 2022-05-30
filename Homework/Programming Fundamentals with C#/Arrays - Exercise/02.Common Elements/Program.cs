using System;
using System.Linq; 

class Program
{
    static void Main(string[] args)

    {
        
        int people = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double cards = double.Parse(Console.ReadLine());
        int ticketsMuseum = int.Parse(Console.ReadLine());

        int totalNights = people * nights;
        double priceCards = cards * 1.6;
        int totalTicketsMuseum = 6 * ticketsMuseum;

        double pricePerPerson = totalNights + priceCards + totalTicketsMuseum ;
        double priceWholeGroup = pricePerPerson * people;
        double totalPrice = priceWholeGroup + (priceWholeGroup * 0.25);

        Console.WriteLine(totalPrice);

    }
}
        }
    }