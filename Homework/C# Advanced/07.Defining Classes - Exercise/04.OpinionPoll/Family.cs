
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; }
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person person, List<Person> people)
        {
            people.Add(person);
        }
        public List<Person> OldestPeople (List <Person> people)
        {
            return people.Where(x => x.Age > 30).OrderBy(person => person.Name).ToList();
        }
    }
}
