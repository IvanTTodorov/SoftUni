using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public interface IBaseHero
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public string CastAbility(); 
    }
}
