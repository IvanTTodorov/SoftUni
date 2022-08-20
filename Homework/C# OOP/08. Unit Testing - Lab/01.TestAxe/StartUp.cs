using System;
public class StartUp
{
    static void Main(string[] args)
    {
        Axe axe = new Axe(10, 0);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);
        Console.WriteLine(axe.DurabilityPoints);
    }
}
