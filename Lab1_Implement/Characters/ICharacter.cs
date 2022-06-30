using Lab1_Implement.CharacterProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.Characters
{
    public interface ICharacter
    {
        //public string[] Attacks { get; set; }
        public int AP { get; set; }
        public int HP { get; set; }
        public CharacterType CharacterType { get; set; }
        public IAttacks Attacks { get; set; }

        void SetAttacks(ICharacter character);
        void SetCharacterHP(ICharacter character);
        void SetCharacterAP(ICharacter character);
        //void SetAttackMethods(ICharacter character);
    }
}
