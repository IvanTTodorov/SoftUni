using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ");
            Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];


                if (!information.ContainsKey(courseName))
                {
                    List<string> students = new List<string>();
                    information.Add(courseName, students);
                    students.Add(studentName);
                }
                else
                {
                    information[courseName].Add(studentName);
                }
                input = Console.ReadLine().Split(" : ");
            }
            foreach (var item in information)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}