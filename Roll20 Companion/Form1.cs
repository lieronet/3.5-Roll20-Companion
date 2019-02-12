using System;
using System.Windows.Forms;

namespace Roll20_Companion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeMacro(object sender, EventArgs e)
        {
            var foo = BAB.Text;
            var bar = Str.Text;



            ResultsBox.Text = foo + " " + bar;
            ResultsBox.Refresh();
        }

        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
