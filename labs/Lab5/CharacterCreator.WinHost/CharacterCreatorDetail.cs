//Luis Reyes
//ITSE 1430
//Lab 3: Character Creator
using System;
using System.ComponentModel;
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
            //Validing UI
            if(!ValidateChildren())
            {
                DialogResult=DialogResult.None;
                return;
            };

            //creating Character
            var character = SaveCharacter();
            var errors = new ObjectValidator().TryValidate(character);
          
            if (errors.Count>0)
                {
                MessageBox.Show(this,errors[0].ErrorMessage, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //validating for Name


        

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required");
                e.Cancel=true;
            }else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;
            var race = control.SelectedItem as string;
            if (String.IsNullOrEmpty(race))
            {
                _errors.SetError(control, "Profession is required");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;
            var race = control.SelectedItem as string;
            if (String.IsNullOrEmpty(race))
            {
                _errors.SetError(control, "race is required");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingStrength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if(value<0 || value>100)
           
            {
                _errors.SetError(control, "Strength must be greater than 0 and less than 100");
                e.Cancel=true;
            }
           else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingIntelligence ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if (value<0|| value>100)
            {
                _errors.SetError(control, "Intelligence must be greater than 0 and less than 100");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingAgility ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if (value<0|| value>100)
            {
                _errors.SetError(control, "Agility must be greater than 0 and less than 100");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingConstitution ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if (value<0|| value>100)
            {
                _errors.SetError(control, "Constitution must be greater than 0 and less than 100");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingcharisma ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var value = GetInt32(control);
            if (value<0|| value>100)
            {
                _errors.SetError(control, "Charisma must be greater than 0 and less than 100");
                e.Cancel=true;
            } else
            {
                _errors.SetError(control, "");
            };
        }




    }
}
