using Lab1_Implement.CharacterProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.Characters
{
    public class Hero : ICharacter
    {
        //public string[] Attacks { get; set; }
        public int AP { get; set; }
        public int HP { get; set; }
        public CharacterType CharacterType { get; set; }
        public IAttacks Attacks { get; set; }

        public Hero(CharacterType characterType)
        {
            this.CharacterType = characterType;
        }

        StatsContext StatsContext = null;

        public void SetAttacks(ICharacter character)
        {
            if (character.CharacterType == CharacterType.Warrior)
            {
                var warrior = new Warrior();
                this.Attacks = warrior;
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
        //    StatsContext = new StatsContext(new Attacks());
        //    StatsContext.SetStats(character);
        //}

        public void SetCharacterAP(ICharacter character)
        {
            StatsContext = new StatsContext(new AP());
            StatsContext.SetStats(character);
        }

        public void SetCharacterHP(ICharacter character)
        {
            StatsContext.SetStat(new HP());
            StatsContext.SetStats(character);
        }
    }
}
