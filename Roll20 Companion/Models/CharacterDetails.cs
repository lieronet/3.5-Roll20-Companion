using System.Collections.Generic;
using System.ComponentModel;


namespace Roll20_Companion.Models
{
    public class CharacterDetails : INotifyPropertyChanged
    {
        public List<Weapon> Weapons { get; set; }
        public Attributes CharacterAttributes { get; set; }
        private int _bab;
        public int BAB
        {
            get { return _bab; }
            set
            {
                _bab = value;

                InvokePropertyChanged(new PropertyChangedEventArgs("BAB"));
            }
        }

        public CharacterDetails()
        {
            CharacterAttributes = new Attributes();
            Weapons = new List<Weapon>();
            BAB = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
