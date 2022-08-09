using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebration
{
    public class Pet : IIdentifiable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
