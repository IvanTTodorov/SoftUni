using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace StudentsName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students?");
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
             
            
            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }
            for (int i = 0; i < n; i++)
            {
                PrintStudent(students[i]);
            }
        }

        static Student ReadStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills: ");
            student.Skills = Console.ReadLine().Split();

            return student;
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"{student.name}, {student.age}, {String.Join(", ", student.skills)}");
        }
    }
}