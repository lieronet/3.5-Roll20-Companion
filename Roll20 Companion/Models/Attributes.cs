namespace Roll20_Companion.Models
{
    class Attributes
    {
        public int StrScore { get; set; }
        public int? StrEnhanncementBonus { get; set; }
        public int? StrTempModifier { get; set; }
        public int DexScore { get; set; }
        public int? DexEnhancementBonus { get; set; }
        public int DexTempModifier { get; set; }
        public int ConScore { get; set; }
        public int? ConEnhancementBonus { get; set; }
        public int ConTempModifier { get; set; }
        public int IntScore { get; set; }
        public int? IntEnhancementBonus { get; set; }
        public int IntTempModifier { get; set; }
        public int WisScore { get; set; }
        public int? WisEnhancementBonus { get; set; }
        public int WisTempModifier { get; set; }
        public int ChaScore { get; set; }
        public int? ChaEnhancementBonus { get; set; }
        public int ChaTempModifier { get; set; }

        public Attributes()
        {
            StrScore = 8;
            DexScore = 8;
            ConScore = 8;
            IntScore = 8;
            WisScore = 8;
            ChaScore = 8;
        }
    }
}
