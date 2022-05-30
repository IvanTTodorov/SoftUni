using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companyInfo = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
            var companies = new Dictionary<string, List<string>>();

            while (companyInfo[0] != "End")
            {
                string nameCompany = companyInfo[0];
                string nameUsers = companyInfo[1];

                if (!companies.ContainsKey(nameCompany))
                {

                    companies.Add(nameCompany, new List<string>());
                    companies[nameCompany].Add(nameUsers);
                }
                else
                {

                    if (!companies[nameCompany].Contains(nameUsers))
                    {
                        companies[nameCompany].Add(nameUsers);
                    }


                    companyInfo = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
                }
            }
            foreach (var pair in companies)
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var id in pair.Value)
                {
                    Console.WriteLine($"--{id}");

                }


            }

        }
    }
}
