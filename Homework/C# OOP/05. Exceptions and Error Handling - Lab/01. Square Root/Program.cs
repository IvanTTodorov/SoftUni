using System;

namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(result(n));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        } 

        public static double result(double n)  
        {  
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            } 
            else
            {
                return Math.Sqrt(n);
            }
        }
    }
}
