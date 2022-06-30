using Lab1_Implement.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    public class HP : ISetStats
    {
        public void SetStats(ICharacter character)
        {
            if (character.CharacterType == CharacterType.Warrior)
            {
                character.HP = 250;
            }
            else if (character.CharacterType == CharacterType.Archer)
            {
                character.HP = 125;
            }
            else if (character.CharacterType == CharacterType.Mage)
            {
                character.HP = 100;
            }
        }
    }
}
