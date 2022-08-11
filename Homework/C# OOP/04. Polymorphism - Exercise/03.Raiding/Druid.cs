using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            : base(name)
        {

        }

        public override int Power { get => base.Power + 80; }
        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
