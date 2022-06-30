using Lab1_Implement.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
    public class AP : ISetStats
    {
        public void SetStats(ICharacter character)
        {
            if (character.CharacterType == CharacterType.Warrior)
            {
                character.AP = 100;
            }
            else if (character.CharacterType == CharacterType.Archer)
            {
                character.AP = 150;
            }
            else if (character.CharacterType == CharacterType.Mage)
            {
                character.AP = 125;
            }
        }
    }
}
