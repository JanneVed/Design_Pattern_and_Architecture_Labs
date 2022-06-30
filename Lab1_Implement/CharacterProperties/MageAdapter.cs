using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    public class MageAdapter : IAttacks
    {
        Mage Mage;

        public MageAdapter(Mage mage)
        {
            this.Mage = mage;
        }
        public string ShieldBash()
        {
            return Mage.IceBall();
        }

        public string Slash()
        {
            return Mage.FireBall();
        }

        public string Stab()
        {
            return Mage.ThunderShock();
        }
    }
}
