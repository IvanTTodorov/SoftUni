using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());


                if (!students.ContainsKey(name))
                {
                    List<double> gradesForStudents = new List<double>();
                    gradesForStudents.Add(grade);
                    students.Add(name, gradesForStudents);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            var newDict = new Dictionary<string, double>();
            foreach (var item in students)
            {
                double averageGrade = item.Value.Sum(x => x) / item.Value.Count;
                if (averageGrade >= 4.50)
                {
                    newDict.Add(item.Key, averageGrade);
                }
            }

            

            foreach (var pair in newDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }

    }
}

