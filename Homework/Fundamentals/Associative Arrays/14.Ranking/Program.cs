using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    public class Program
    {
        static void Main(string[] args)
        {
            var CourseInformation = new Dictionary<string, string>();
            string input = String.Empty;
             
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] info = input.Split(":");
                string courseName = info[0];
                string password = info[1]; 

                if (!CourseInformation.ContainsKey(courseName))
                {
                    CourseInformation.Add(courseName, password);
                }
            }
             

             

            List <Student> studentsList = new List<Student>();  
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] info = input.Split("=>");
                string courseName = info[0];
                string password = info[1];
                string studentName = info[2];
                int points = int.Parse(info[3]); 

                if (!CourseInformation.ContainsKey(courseName) || CourseInformation[courseName] !=(password))
                {
                    continue;
                } 

                if (!studentsList.Any(x=>x.Name == studentName)) 
                {
                    Student student = new Student(); 
                    student.Name = studentName;
                    student.CourseAndPoints = new Dictionary<string, int>();
                    student.CourseAndPoints.Add(courseName, points);  
                    studentsList.Add(student);  
                } 
                else if (studentsList.Any(x => x.Name == studentName)) 
                {
                    var currentStudent = studentsList.First(x => x.Name == studentName); 
                    if (!currentStudent.CourseAndPoints.Any(x=> x.Key == courseName))
                    {
                        currentStudent.CourseAndPoints.Add(courseName, points);
                    } 
                    else
                    {
                        if (currentStudent.CourseAndPoints[courseName] < points)
                        {
                            currentStudent.CourseAndPoints[courseName] = points;
                        }
                    }
                }
            } 

           
                var bestStudent = studentsList.OrderByDescending(x=> x.CourseAndPoints.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestStudent.Name} with total {bestStudent.CourseAndPoints.Values.Sum()} points.");
            Console.WriteLine("Ranking:");  
            foreach (var student in studentsList.OrderBy(x=>x.Name))
            {
                Console.WriteLine(student.Name);
                foreach (var pair in student.CourseAndPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }

        }
    } 

    public class Student
    {
        public string Name { get; set;}
        public Dictionary <string, int >  CourseAndPoints { get; set; }

    }
}