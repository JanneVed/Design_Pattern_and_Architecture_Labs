using Lab1_Implement.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.CharacterProperties
{
     public class PropertiesManager
    {
        public static void StatSetter(ICharacter character)
        {
            character.SetCharacterAP(character);
            character.SetCharacterHP(character);
        }

        public static void AttacksSetter(ICharacter character)
        {
            character.SetAttacks(character);
        }
    }
}
