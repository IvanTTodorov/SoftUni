﻿using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                return;
            }
            Person person;

            if (age <= 15)
            {
                person = new Child(name, age);
            }
            else
            {
                person = new Person(name, age);
            }

            Console.WriteLine(person);
        }
    }
}