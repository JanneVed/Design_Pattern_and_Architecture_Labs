using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    public class ArcherAdapter : IAttacks
    {
        Archer Archer;

        public ArcherAdapter(Archer archer)
        {
            this.Archer = archer;
        }
        public string ShieldBash()
        {
            return Archer.BowSmash();
        }

        public string Slash()
        {
            return Archer.ArrowShot();
        }

        public string Stab()
        {
            return Archer.FireArrowShot();
        }
    }
}
