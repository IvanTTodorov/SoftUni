using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Regex.Split(Console.ReadLine(), @" *,{1} *").OrderBy(x => x).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                MatchCollection health = Regex.Matches(input[i], @"[^+\-*/.\d]");
                MatchCollection damage = Regex.Matches(input[i], @"((|-)\d+\.\d+|(|-)\d+)");
                MatchCollection mathSymbols = Regex.Matches(input[i], @"[\*\/]");

                int resultHealth = Health(health, input);
                double resultDamage = Damage(damage);
                resultDamage = MathOperations(mathSymbols, resultDamage);

                Console.WriteLine($"{input[i]} - {resultHealth} health, {resultDamage:f2} damage");

            }
        }
        public static int Health(MatchCollection health, List<string> input)
        {
            string name = String.Concat(health);
            int resultHealth = 0;
            for (int i = 0; i < name.Length; i++)
            {
                resultHealth += name[i];
            }
            return resultHealth;
        }
        public static double Damage(MatchCollection damage)
        {
            double resultDamage = 0;
            for (int i = 0; i < damage.Count; i++)
            {
                resultDamage += double.Parse(damage[i].Value);
            }
            return resultDamage;
        }
        public static double MathOperations(MatchCollection mathOperations, double resultDamage)
        {

           foreach(var item in mathOperations)
            {
                string newItem = item.ToString(); 
                if(newItem == "*")
                {
                    resultDamage *= 2;
                } 
                else
                {
                    resultDamage /= 2;
                }
            }
            return resultDamage; 
        }
    }
}