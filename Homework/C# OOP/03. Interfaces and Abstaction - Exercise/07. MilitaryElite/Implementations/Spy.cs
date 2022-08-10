using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumOfSpy )  
            : base(id, firstName, lastName)
        {
            CodeNumOfSpy = codeNumOfSpy;
        }

        public int CodeNumOfSpy { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id:f2}");
            sb.AppendLine($"{CodeNumOfSpy:f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
