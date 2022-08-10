using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)  
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name:  {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
