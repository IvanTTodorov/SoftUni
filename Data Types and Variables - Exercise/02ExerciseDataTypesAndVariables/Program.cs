using System;

class Program
{
    static void Main(string[] args)

    { 

        int firsr = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine()); 
        int third = int.Parse(Console.ReadLine());
        int four = int.Parse(Console.ReadLine());

        int firstOperation = firsr + second;
        int secondOperation = firstOperation / third; 
        int thirdOperation = secondOperation * four;

        Console.WriteLine(thirdOperation);




    }
}
 