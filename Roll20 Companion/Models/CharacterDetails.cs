using System.Collections.Generic;

namespace Roll20_Companion.Models
{
    public class CharacterDetails
    {
        public List<Weapon> Weapons;
        public Attributes CharacterAttributes;
        public int BAB;

        public CharacterDetails()
        {
            CharacterAttributes = new Attributes();
            Weapons = new List<Weapon>();
            BAB = 0;
        }
    }
}
