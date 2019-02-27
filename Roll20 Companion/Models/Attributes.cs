namespace Roll20_Companion.Models
{
    public class Attributes
    {
        public CharacterAttribute Str;
        public CharacterAttribute Dex;
        public CharacterAttribute Con;
        public CharacterAttribute Int;
        public CharacterAttribute Wis;
        public CharacterAttribute Cha;

        public Attributes()
        {
            Str = new CharacterAttribute();
            Dex = new CharacterAttribute();
            Con = new CharacterAttribute();
            Int = new CharacterAttribute();
            Wis = new CharacterAttribute();
            Cha = new CharacterAttribute();
        }
    }
}
