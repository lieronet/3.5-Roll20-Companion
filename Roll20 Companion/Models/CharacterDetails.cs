using System.Collections.Generic;

namespace Roll20_Companion.Models
{
    class CharacterDetails
    {
        public List<Weapon> Weapons;
        public Attributes CharacterAttributes;
        public int BAB;

        public CharacterDetails()
        {
            CharacterAttributes = new Attributes();
            BAB = 0;
        }
    }
}
