using System;
using System.Collections.Generic;
using System.Linq;

namespace Vlogger
{
    class Vlogger
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataBaseCourses = new Dictionary<string, string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(":");
                string course = data[0];
                string password = data[1];
                dataBaseCourses.Add(course, password);
            }


            Dictionary<string, Dictionary<string, int>> userNameInformation = new Dictionary<string, Dictionary<string, int>>();
            string input2 = string.Empty;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] info = input2.Split("=>");
                string currentCourse = info[0];
                string currentPassword = info[1];
                string name = info[2];
                int point = int.Parse(info[3]);

                if (dataBaseCourses.ContainsKey(currentCourse))
                {
                    if (dataBaseCourses[currentCourse] == currentPassword)
                    {
                        if (!userNameInformation.ContainsKey(name))
                        {
                            userNameInformation.Add(name, new Dictionary<string, int>());
                        }
                        if (!userNameInformation[name].ContainsKey(currentCourse))
                        {
                            userNameInformation[name].Add(currentCourse, point);
                        }
                        else
                        {
                            if (userNameInformation[name][currentCourse] < point)
                            {
                                userNameInformation[name][currentCourse] = point;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
            }




            int maxPoints = 0;
            string bestPlayer = string.Empty;
            foreach (var item in userNameInformation)
            {
                int currentPoints = 0;
                foreach (var points in item.Value)
                {
                    currentPoints += points.Value;
                }
                if (currentPoints > maxPoints)
                {
                    maxPoints = currentPoints;
                    bestPlayer = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestPlayer} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var student in userNameInformation.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var item in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}