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
            List<string> input = Regex.Split(Console.ReadLine(), @" *,{1} *").OrderBy(x=>x).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                MatchCollection healthRegex = Regex.Matches(input[i], @"[^+\-*/.\d]");
                MatchCollection digits = Regex.Matches(input[i], @"((|-)\d+\.\d+|(|-)\d+)");
                MatchCollection mathSymbols = Regex.Matches(input[i], @"[\*\/]");

                int resultHealth = Health(healthRegex);
                double resultDamage = Damage(digits);

                resultDamage = LastDamageResult(resultDamage, mathSymbols);

                Console.WriteLine($"{input[i]} - {resultHealth} health, {resultDamage:f2} damage");

            }
        }
        public static int Health(MatchCollection healthRegex)
        {
            string name = String.Concat(healthRegex);
            int health = 0;
            for (int i = 0; i < name.Length; i++)
            {
                health += name[i];
            }
            return health;
        }
        public static double Damage(MatchCollection digits)
        {
            double damage = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                damage += double.Parse(digits[i].Value);
            }
            return damage;
        }
        public static double LastDamageResult(double resultDamage, MatchCollection mathSymbols)
        {

            for (int i = 0; i < mathSymbols.Count; i++)
            {
                if(mathSymbols[i].Value == "*")
                {
                    resultDamage *= 2;
                } 
                else if (mathSymbols[i].Value == "/")
                {
                    resultDamage /= 2; 
                }
            }

            return resultDamage;
        }
    }
}