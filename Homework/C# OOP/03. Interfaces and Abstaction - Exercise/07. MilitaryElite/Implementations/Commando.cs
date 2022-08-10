using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MilitaryElite {

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }


        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName)
        {
            var mission = Missions.FirstOrDefault(x => x.CodeName == codeName);
            if (mission == null)
            {

            }
            else
            {
                mission.State = State.Finished;
            }
        }

      
            public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"{item.ToString()}");
            } 
            return sb.ToString().TrimEnd();
        }
    }
    }


