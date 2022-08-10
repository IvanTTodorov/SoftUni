using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpy : ISoldier
    {
        public int CodeNumOfSpy { get; set; }
    }
}
