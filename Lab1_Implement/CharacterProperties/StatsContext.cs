using Lab1_Implement.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    // Part of strategy pattern
    class StatsContext
    {
        private ISetStats Stats;

        public StatsContext(ISetStats SetStats)
        {
            this.Stats = SetStats;
        }

        public void SetStat(ISetStats SetStats)
        {
            this.Stats = SetStats;
        }

        public void SetStats(ICharacter character)
        {
            Stats.SetStats(character);
        }
    }
}
