using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    public class Warrior : IAttacks
    {
        public string ShieldBash()
        {
            return "Shield bash";
        }

        public string Slash()
        {
            return "Sword Slash";
        }

        public string Stab()
        {
            return "Stab";
        }
    }
}
