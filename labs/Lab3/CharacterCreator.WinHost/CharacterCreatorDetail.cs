using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class CharacterCreatorDetail : Form
    {
        public CharacterCreatorDetail ()
        {
            InitializeComponent();
        }
        public Character Character { get; set;}
        protected override void OnLoad ( EventArgs e )
        {
            //call the base member
            base.OnLoad(e);
            //load if character set
            if (Character != null)
                LoadCharacter(Character);
        }

        private void OnSave ( object sender, EventArgs e )
        {
            var character = SaveCharacter();
            if(character.Validate(out var error))
                {
                MessageBox.Show(error, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult=DialogResult.None;
                return;
            };
            Character=character;
            this.DialogResult=DialogResult.OK;
            Close();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private int GetInt32(Control control)
        {
            var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }
        private void LoadCharacter(Character character)
        {
            txtName.Text= character.Name;
            cbProfession.SelectedItem=character.profession;
            cbRace.SelectedItem=character.race;
            txtStrength.Text=character.Strength.ToString();
            txtIntelligence.Text=character.Intelligence.ToString();
            txtAgility.Text=character.Agility.ToString();
            txtConstitution.Text=character.Constitution.ToString();
            txtCharmisa.Text=character.Charisma.ToString();
            txtBio.Text=character.Biography;

        }

        private Character SaveCharacter ()
        {
            var character = new Character();
            character.Name= txtName.Text;
            character.profession=cbProfession.SelectedItem as string;

            character.race=cbRace.SelectedItem as string;
            character.Strength=GetInt32(txtStrength);

            character.Intelligence=GetInt32(txtIntelligence);
            character.Agility=GetInt32(txtAgility);

            character.Constitution=GetInt32(txtConstitution);
            character.Charisma=GetInt32(txtCharmisa);
            character.Biography=txtBio.Text;

                return character;
        }
    }
}
