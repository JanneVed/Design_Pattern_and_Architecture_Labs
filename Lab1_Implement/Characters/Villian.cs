using Lab1_Implement.CharacterProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.Characters
{
    public class Villian : ICharacter
    {
        //public string[] Attacks { get; set; }
        public int AP { get; set; }
        public int HP { get; set; }
        public CharacterType CharacterType { get; set; }
        public IAttacks Attacks { get; set; }

        public Villian(CharacterType characterType)
        {
            this.CharacterType = characterType;
        }

        StatsContext StatsContext = null;

        public void SetAttacks(ICharacter character)
        {
            if (character.CharacterType == CharacterType.Warrior)
            {
                this.Attacks = new Warrior();
            }
            else if (character.CharacterType == CharacterType.Archer)
            {
                var archer = new Archer();
                this.Attacks = new ArcherAdapter(archer);
            }
            else if (character.CharacterType == CharacterType.Mage)
            {
                var mage = new Mage();
                this.Attacks = new MageAdapter(mage);
            }
        }

        //public void SetAttackMethods(ICharacter character)
        //{
        //    StatsContext = new StatsContext(new AttacksOld());
        //    StatsContext.SetStats(character);
        //}

        public void SetCharacterAP(ICharacter character)
        {
            StatsContext = new StatsContext(new AP());
            StatsContext.SetStats(character);
        }

        public void SetCharacterHP(ICharacter character)
        {
            StatsContext = new StatsContext(new HP());
            StatsContext.SetStats(character);
        }
    }
}
