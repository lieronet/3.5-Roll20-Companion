using System.ComponentModel;

namespace Roll20_Companion.Models
{
    public class CharacterAttribute : INotifyPropertyChanged
    {
        #region properties
        private int _abilityScore;
        private int? _tempMod;
        private int? _enhancementBonus;

        public int AbilityScore
        {
            get { return _abilityScore; }
            set
            {
                _abilityScore = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AbilityScore"));
            }
        }

        public int? TemporaryModifier
        {
            get { return _tempMod; }
            set
            {
                _tempMod = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TemporaryModifier"));
            }
        }

        public int? EnhancementBonus
        {
            get { return _enhancementBonus; }
            set
            {
                _enhancementBonus = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EnhancementBonus"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        #endregion  

        public CharacterAttribute()
        {
            AbilityScore = 8;
        }
    }
}
