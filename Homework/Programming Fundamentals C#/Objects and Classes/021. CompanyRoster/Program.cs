using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Department> newDepartment = new List<Department>();
            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string name = information[0];
                double salary = double.Parse(information[1]);
                string department = information[2];

                if (!newDepartment.Any(x => x.DepartmentName == department))
                {
                    Department allDepartments = new Department(department);
                    newDepartment.Add(allDepartments);
                }
                newDepartment.Find(x => x.DepartmentName == department).NameAndSalary(name, salary);

            }
            Department bestDepartment = newDepartment.OrderByDescending(x => x.TotalSalary / x.CurrentName.Count ).First();
            Console.WriteLine(bestDepartment.DepartmentName);

            List<Employee> printableList = bestDepartment.CurrentName.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, printableList));
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }
    public class Department
    {
        public string DepartmentName { get; set; }

        public List<Employee> CurrentName = new List<Employee>();
        public double TotalSalary { get; set; }

        public void NameAndSalary(string name, double salary)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Salary = salary;
            CurrentName.Add(employee);

            TotalSalary += salary;
        }
        public Department(string department)
        {
            DepartmentName = department;
        }
    }
}
