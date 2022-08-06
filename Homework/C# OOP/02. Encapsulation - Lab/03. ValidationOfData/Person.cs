using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary; 

        public string FirstName
        {
            get
            {
                return firstName;
            }
           private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                    
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
           private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                    
                }
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
           private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                    
                }
                age = value;
            }
        }
        public decimal Salary {
            get
            {
                return salary;
            }
           private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percantage)
        {
            if (Age >= 30)
            {
                Salary += Salary * (percantage / 100);
            }
            else
            {
                Salary += Salary * (percantage / 200);

            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
