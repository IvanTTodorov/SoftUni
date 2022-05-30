using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            List <Student> studentList = new List <Student>();  
            while(input != "end")
            {
                string[] studentInfo = input.Split(); 
                Student student = new Student(studentInfo[0], studentInfo[1], int.Parse(studentInfo[2]), studentInfo[3]); 
                studentList.Add(student);
                input = Console.ReadLine();
            } 


            string cityName = Console.ReadLine();
            List<Student> FilteredStuden = studentList.Where(x => x.HomeTown == cityName).ToList(); 
            foreach (Student student in FilteredStuden)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    public class Student { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age,  string homeTown)
        {
            FirstName = firstName;
            LastName = lastName; 
            Age = age;
            HomeTown = homeTown; 
        }
    }

}