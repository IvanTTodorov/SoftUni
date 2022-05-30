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
            string command = Console.ReadLine();
            List<Student> studentList = new List<Student>();
            while (command != "end")
            {
                string[] studentInput = command.Split();



                string firstName = studentInput[0];
                string lastName = studentInput[1];
                int age = int.Parse(studentInput[2]);
                string city = studentInput[3];


                if (IsTheSame(firstName, lastName, studentList))
                {
                    ReturnStudent(studentList, firstName, lastName, city, age);
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;

                    studentList.Add(student);
                }
                command = Console.ReadLine();
            }

            string currentCity = Console.ReadLine();
            List<Student> filterCity = studentList.Where(x => x.City == currentCity).ToList(); 
            foreach (Student student in filterCity)
            {
 
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
               
            }

        }
        public static bool IsTheSame(string firstName, string lastName, List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }


        static void ReturnStudent(List<Student> studentList, string firstName, string lastName, string city, int age)
        {
            foreach (Student student in studentList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.City = city;
                    student.Age = age;
                }
            }
        }
    }
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
