using System;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        //Exit 
        private void OnFileExit ( object sender, EventArgs e )
        {
            //Display of confirmation to exit
            var result =MessageBox.Show(this, "Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result!=DialogResult.Yes)
                return;

            //Close the form
            Close();
        }

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterCreatorDetail();
            if (form.ShowDialog(this)== DialogResult.Cancel)
                return;

            _character=form.Character;
            UpdateUI();

        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            //Charcter will delete if it exist
            if (character==null) 
            return;
            var result = MessageBox.Show(this, $"Are you sure that you want to delete'{character.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result!=DialogResult.Yes)
                return;

            _character=null;
            UpdateUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            //reutrn if null
            var character = GetSelectedCharacter();
            if (character==null)
                return;
            
            var form = new CharacterCreatorDetail();
            form.Character= character;

            if (form.ShowDialog(this)== DialogResult.Cancel)
                return;

            _character=form.Character;
            UpdateUI();
        }
        //Updates th3e list ong the UI
       
        private Character GetSelectedCharacter ()
        {
            return lstCharacter.SelectedItem as Character;
            
        }
        private void UpdateUI ()
        {

            
            var count = (_character != null) ? 1 : 0;

            Character[] characters = new Character[count];
                    if (_character != null)
                characters[0]=_character;
            
            lstCharacter.DataSource = characters;
            lstCharacter.DisplayMember="Name";
           
           
        }
        private Character _character;
    }
}
