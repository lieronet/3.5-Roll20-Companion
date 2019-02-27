using Roll20_Companion.Models;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Roll20_Companion
{
    partial class CharacterSheet: Form
    {
        public CharacterDetails Character;

        public CharacterSheet()
        {
            InitializeComponent();
            Character = new CharacterDetails();

            strEnhBonus.DataBindings.Add("Text", Character.CharacterAttributes.Str, "EnhancementBonus");
            conEnhBonus.DataBindings.Add("Text", Character.CharacterAttributes.Con, "EnhancementBonus");
        }

        public CharacterSheet(FileStream characterSheet)
        {
            InitializeComponent();
            //TODO: once I have a window for loading in a character, deserialize the XML there and pass in the object
            //that way I can do error handling before opening the window
            XmlSerializer mySerializer = new XmlSerializer(typeof(CharacterDetails));
            Character = (CharacterDetails)mySerializer.Deserialize(characterSheet);
            
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File|*.xml";
            sfd.Title = "Save Character";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(File.Create(sfd.FileName)))
                {
                    XmlSerializer myXmlSerializer = new XmlSerializer(typeof(CharacterDetails));
                    //writer.Write(myXmlSerializer.Serialize(writer,)
                    myXmlSerializer.Serialize(writer, Character);
                    writer.Close();
                }
            }
        }

        private void LoadButton_OnClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "Open Character";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var characterSheet = ofd.OpenFile();

                XmlSerializer mySerializer = new XmlSerializer(typeof(CharacterDetails));
                Character = (CharacterDetails)mySerializer.Deserialize(characterSheet);
            }
        }
    }
}
