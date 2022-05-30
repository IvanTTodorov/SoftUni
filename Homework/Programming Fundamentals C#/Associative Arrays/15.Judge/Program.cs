using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            List<Course> courseList = new List<Course>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] info = input.Split(" -> ");
                string studentName = info[0];
                string courseName = info[1];
                int points = int.Parse(info[2]);


                if (!courseList.Any(x => x.CourseName == courseName))
                {
                    Course course = new Course();
                    course.CourseName = courseName;
                    course.UserAndPoints = new Dictionary<string, int>();
                    course.UserAndPoints.Add(studentName, points);
                    courseList.Add(course);
                }
                else
                {
                    var currentCourse = courseList.First(x => x.CourseName == courseName);
                    if (!currentCourse.UserAndPoints.Any(x => x.Key == studentName))
                    {
                        currentCourse.UserAndPoints.Add(studentName, points);
                    }
                    else
                    {
                        if (currentCourse.UserAndPoints[studentName] < points)
                        {
                            currentCourse.UserAndPoints[studentName] = points;
                        }
                    }
                }

            }
            var totalPoints = new SortedDictionary<string, int>();
            foreach (var item in courseList)
            {
                foreach (var pair in item.UserAndPoints)
                {
                    if (!totalPoints.ContainsKey(pair.Key))
                    {
                        totalPoints.Add(pair.Key, pair.Value);
                    }
                    else
                    {
                        totalPoints[pair.Key] += pair.Value;
                    }
                }
            }
            Print(courseList, totalPoints);
        }
        public class Course
        {
            public string CourseName { get; set; }
            public Dictionary<string, int> UserAndPoints { get; set; }

        }
        public static void Print(List<Course> courseList, SortedDictionary<string, int> totalPoints)
        {
            
            foreach (var item in courseList)  
            {
                Console.WriteLine($"{item.CourseName}: {item.UserAndPoints.Count} participants");
                int position = 1;
                foreach (var pair in item.UserAndPoints.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                    {
                    Console.WriteLine($"{position}. {pair.Key} <::> {pair.Value}");
                    position++;
                    }
            }

            int position1 = 1;
            Console.WriteLine("Individual standings:");
            foreach (var pair in totalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position1}. {pair.Key} -> {pair.Value}");
                position1++;
            }
        }
    }
}