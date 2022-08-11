using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero : IBaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
            Power = 0;
        }

        public string Name { get; set; }
        public virtual int Power { get; set; }

        public abstract string CastAbility();
        
    }
}
