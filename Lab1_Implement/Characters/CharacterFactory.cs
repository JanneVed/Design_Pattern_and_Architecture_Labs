using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Implement.Characters
{
    public class CharacterFactory
    {
        public ICharacter CreateCharacter(Side side, CharacterType characterType)
        {
            ICharacter character = null;

            if (side == Side.Hero)
            {
                character = new Hero(characterType);
            }
            else if (side == Side.Villian)
            {
                character = new Villian(characterType);
            }
            return character;
        }
    }
}
