using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators

{ 
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;  
        }
        public string Name => name;
        public int Age => age;

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            return result;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            Person other = obj as Person; 
            if(other == null)
            {
                return false;
            }

            return Age == other.Age && Name == other.Name;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}

