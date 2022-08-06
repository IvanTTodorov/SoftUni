﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public IReadOnlyList<Person> FirstTeam
        {
            get
            {
                return firstTeam.AsReadOnly();
            }
        }
        public IReadOnlyList<Person> ReserveTeam
        {
            get
            {
                return reserveTeam.AsReadOnly();
            }
        }
        public string Name => name;

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

      public void AddPlayer(Person person)
        {
            if (person.Age < 40 )
            {
                firstTeam.Add(person);
            } 
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}
