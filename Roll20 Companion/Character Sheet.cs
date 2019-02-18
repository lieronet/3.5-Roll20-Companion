using Roll20_Companion.Models;
using System;
using System.Windows.Forms;

namespace Roll20_Companion
{
    partial class CharacterSheet: Form
    {
        public CharacterDetails Character;

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void MakeMacro(object sender, EventArgs e)
        {
            var foo = BAB.Text;
            var bar = StrScore.Text;
        }

        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
