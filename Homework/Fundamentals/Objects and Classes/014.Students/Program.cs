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
            int n = int.Parse(Console.ReadLine());
            
            List<Students> students = new List<Students>(); 

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                string grade = input[2];

                Students student = new Students();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = double.Parse(grade);

                students.Add(student);
            }
            List<Students> changedStudents = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, changedStudents));
         }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}