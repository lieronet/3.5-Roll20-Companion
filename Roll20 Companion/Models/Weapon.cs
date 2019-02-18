namespace Roll20_Companion.Models
{
    class Weapon
    {
        public Dice DamageDieSize { get; set; }
        public int DamageDice { get; set; }
        public int Range { get; set; }
        public DamageType DamageType { get; set; }
        public bool OneHanded { get; set; }
        public bool Light { get; set; }
        public int CritLowerBound { get; set; }
        public int CritMultiplier { get; set; }
        public string Name { get; set; }

        public Weapon() : base()
        {

        }

    }
}
